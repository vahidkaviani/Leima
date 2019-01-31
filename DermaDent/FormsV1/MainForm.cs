using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSoftShopcheeBot;
using DSDentAssist;
using System.Runtime.InteropServices;
using DermaDent.Properties;
using System.IO;
using DermaDent.SQLTableTracker;
using marlie.TumbnailDotnet;
using DermaDent.Document;

namespace DermaDent
{
    public partial class MainForm : Form
    {

        dbMonitor _dbMonitor;

        public static string[] StatusDetail = {""
                                                ,"در انتظار"
                                                ,"معالجه"
                                                ,"کنسل بیمار"
                                                ,"کنسل پزشک"
                                                ,"حذف"
                                                ,"عدم ثبت"
                                                ,"غیبت" };
        public static Color[] statusColor = {Color.White
                                            ,Color.Black
                                            ,Color.Green
                                            ,Color.Orange
                                            ,Color.Purple
                                            ,Color.DimGray
                                            ,Color.Blue
                                            ,Color.Red};
        public MainForm()
        {
            InitializeComponent();
           
            _dbMonitor = new dbMonitor();

            RefreshQue();

            TXTBXNameID.KeyDown += new KeyEventHandler(tb_KeyDown);
            LSTVUPatientDocumentList.DragDrop += new DragEventHandler(FileDragEventArgsHandler);

            LSTVUPatientDocumentList.DragOver += new DragEventHandler(textBoxFile_DragOver);

            //DocumentList.SelectionChanged+=new EventHandler()
            DefaultPatientdocument();

            

            UpdateServiceCombobox();

            CMBBXTreatmentPlan.AutoCompleteMode = AutoCompleteMode.Suggest;
            CMBBXTreatmentPlan.AutoCompleteSource = AutoCompleteSource.ListItems;

            CMBBXDoctorNameAndID.AutoCompleteMode = AutoCompleteMode.Suggest;
            CMBBXDoctorNameAndID.AutoCompleteSource = AutoCompleteSource.ListItems;

            PatientDataGridViewUpdate();
            for (int i = 0; i < DTGVPatientName.Columns.Count; i++)
            {
                DTGVPatientName.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }

            SaveToFileAddress.Text = Settings.Default.PatientDocumentSavePath;

            CMBBXDoctorNameAndIDUPdate();
            InitImageViewer();
            CHKBXToday.Checked = true;
        }

        public void DefaultPatientQue()
        {
            //var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
            //                        ,[FNamesick]
            //                        ,[LNamesick]
            //                        ,[meliCode]
            //                        ,[Birthday]
            //                        ,[Tel]
            //                        FROM [InfoSick]
            //                        ORDER BY date_create DESC");

            //var result = Transaction.GetOveralViewOfVisitedTime(DateTime.Now.AddDays(-1)
            //                                                   , DateTime.Now.AddYears(1)
            //                                                   ,);
            //dataGridView1.DataSource = result;
            searchPatintProfile();
        }

        public void PatientGridViewUpdate()
        {
        }
        public void DefaultPatientdocument()
        {
            var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    FROM [InfoSick]
                                    ORDER BY date_create ASC");
            DocumentList.DataSource = result;
        }
        public void RefreshQue()
        {
            //CurrentQue.Items.Add("test");
            try
            {
                DefaultPatientQue();
                dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
                dataGridView1.MouseClick += new MouseEventHandler(dataGridView1_MouseClick);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (e.ColumnIndex == dgv.Columns["Reservedtime"].Index)
                {

                    if (e.Value != null)
                    {
                        dgv.Rows[e.RowIndex].Cells["_Time"].Value = ((DateTime)e.Value).ToString("HH:mm");
                        e.Value = PersianDateTime.GetPersianDate((DateTime)e.Value);
                    }

                    //int data = (int)(decimal)dgv.Rows[e.RowIndex].Cells[0].Value;
                    //if (data > 10000001)
                    //    e.CellStyle.BackColor = Color.Red;
                    //else
                    //    e.CellStyle.BackColor = Color.Green;
                }
                else if (e.ColumnIndex == dgv.Columns["PresentState"].Index)
                {
                    if (e.Value == null)
                        return;

                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = statusColor[(short)e.Value];
                    e.Value = StatusDetail[(short)e.Value];
                }
            }
            catch { }
        }
        int SelectedItemListview = -1;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedItemListview = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (SelectedItemListview >= 0)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add("ثبت گزارش درمان", RegisterTreatmentPlanclick);
                    m.MenuItems.Add("غیبت", PatientAbsentclick);
                    m.MenuItems.Add("کنسل بیمار", PatientCancelClick);
                    m.MenuItems.Add("کنسل پزشک", DoctorCancelclick);
                    m.MenuItems.Add("حذف", RemoveTimeclick);
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }

        }
        int SelectedPresentTime = -1;
        public void EditDoctorItem(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedPresentTime = LSTVUDoctorTimes.HitTest(e.X, e.Y).Item.Index;
                if (SelectedPresentTime >= 0)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add("حذف", RemovePresenttime);
                    m.Show(LSTVUDoctorTimes, new Point(e.X, e.Y));
                }
            }
        }

        private void RemovePresenttime(object sender, EventArgs e)
        {
            int PresentTime = int.Parse(LSTVUDoctorTimes.Items[SelectedPresentTime].SubItems[0].Text);
            if (SelectedPresentTime >= 0)
            {
                Transaction.DisabledoctorPresentTime(ID: PresentTime);
                int DoctorID = int.Parse(((string)CMBBXDoctorNameAndID.SelectedItem).Split(',')[0]);
                UpdateDoctorTimes(DoctorID);
            }
        }
        private void PatientAbsentclick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((decimal)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 7);
            }
        }

        private void PatientCancelClick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 3);
            }
        }

        private void DoctorCancelclick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 4);
            }
        }

        private void RemoveTimeclick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 5);
            }
        }

        private void RegisterTreatmentPlanclick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["PatientID"].Value))
                return;
            if (SelectedItemListview >= 0)
            {
                if (dataGridView1.Rows.Count < 0)
                    return;
                FRMTreatmentReport frm = new FRMTreatmentReport(int.Parse((string)dataGridView1.Rows[SelectedItemListview].Cells["PatientID"].Value), (int)dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value);
                frm.ShowDialog();
            }
        }

        public void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n;
                bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);

                if (isNumeric)
                {
                    searchPatintProfile(null, ((TextBox)sender).Text);
                }
                else
                    searchPatintProfile(((TextBox)sender).Text, null);

            }
        }

        void searchPatintProfile(string LName = null, string FileID = null, DateTime? From = null, DateTime? To = null)
        {
            if (CHKBXToday.Checked)
            {
                From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                To = new DateTime(From.Value.Year, From.Value.Month, From.Value.Day, 23, 59, 59);
            }
            if (CHKBXTomorrow.Checked)
            {
                To = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59).AddDays(1);
                if (CHKBXToday.Checked)
                    From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                else
                    From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            }
            if (!From.HasValue)
                From = DateTime.Now.AddMonths(-2);
            if (!To.HasValue)
                To = DateTime.Now.AddMonths(1);
            throw new NotImplementedException();
            //var result = Transaction.GetOveralViewOfVisitedTime(From.Value
            //                                                        , To.Value
            //                                                       , PatientLastName: LName
            //                                                       , PatientID: FileID);
            //dataGridView1.DataSource = result;
            //}
            //else if (FileID != null)
            //{
            //    var result = Transaction.GetOveralViewOfVisitedTime(DateTime.Now.AddYears(-99)
            //                                                        , DateTime.Now.AddYears(99)
            //                                                       , PatientID: FileID);

            //    dataGridView1.DataSource = result;
            //}
        }
        public void searchPatintProfileByID(string NationalCode)
        {
            var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    FROM [InfoSick]" + string.Format("WHERE {0} ={1}", "meliCode ", NationalCode) +
                                    "ORDER BY date_create ASC "
                          );
            dataGridView1.DataSource = result;
        }

        private void SearchByText(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Trim().Length == 0)
                DefaultPatientQue();

            if (((TextBox)sender).Text.Trim().Length < 3)
                return;

            int n;
            bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);
            if (isNumeric)
                return;
            if (!isNumeric)
            {
                searchPatintProfile(((TextBox)sender).Text, null);
            }
        }

        public void tb_DentFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n;
                bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);

                if (isNumeric)
                {
                    searchPatintProfile(null, ((TextBox)sender).Text);
                }
                else
                    searchPatintProfile(((TextBox)sender).Text, null);

            }
        }

        public void FileDragEventArgsHandler(object sender, DragEventArgs e)
        {
            string[] Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var dm = GetUserDocument(LBLIDCode.Text);

            dm.SaveFile(Files);
            DocumentList_SelectionChanged(null, null);
        }
        private void textBoxFile_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        /***********************************************************/
        public void DocTXTBX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n;
                bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);

                if (isNumeric)
                {
                    searchPatintProfileDoc(null, ((TextBox)sender).Text);
                }
                else
                    searchPatintProfileDoc(((TextBox)sender).Text, null);

            }
        }

        void searchPatintProfileDoc(string LName = null, string FileID = null)
        {
            if (LName != null)
            {
                var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    FROM [InfoSick]" +
                                        string.Format("WHERE {0} LIKE N'%{1}%'", "LNamesick", LName) +
                                    "ORDER BY date_create DESC ");
                DocumentList.DataSource = result;
            }
            else if (FileID != null)
            {
                var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    FROM [InfoSick]" + string.Format("WHERE {0} = '{1}'", "IDsick", FileID) +
                                    "ORDER BY date_create DESC "
                                            );

                DocumentList.DataSource = result;
            }
        }
        public void searchPatintProfileByIDDoc(string NationalCode)
        {
            var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    FROM [InfoSick]" + string.Format("WHERE {0} ={1}", "meliCode ", NationalCode) +
                                    "ORDER BY date_create ASC "
                          );
            DocumentList.DataSource = result;
        }

        private void SearchByTextDoc(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Trim().Length == 0)
                DefaultPatientQue();
            if (((TextBox)sender).Text.Trim().Length < 3)
                return;
            int n;
            bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);
            if (isNumeric)
                return;
            if (!isNumeric)
            {
                searchPatintProfile(((TextBox)sender).Text, null);
            }
        }

        public void DocPageSearch(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n;
                bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);

                if (isNumeric)
                {
                    searchPatintProfile(null, ((TextBox)sender).Text);
                }
                else
                    searchPatintProfile(((TextBox)sender).Text, null);

            }
        }
        /***********************************************************/

        public void UpdateServiceCombobox()
        {

            CMBBXTreatmentPlan.Items.Clear();
            var result = new DatabaseManager().GetData(@"SELECT TOP 1000 [IDService]

      ,[NameService]

  FROM  [infoService]
  WHERE IDService>99");

            for (int i = 0; i < result.Rows.Count; i++)
            {
                CMBBXTreatmentPlan.Items.Add(result.Rows[i][0] + "," + result.Rows[i][1]);
            }

            CMBBXTreatmentPlan.Text = "Please define Service";
        }
        public void UpdateDoctorList(DateTime Desiredtime)
        {
            int dayofweek = (int)Desiredtime.DayOfWeek + 2;
            if (dayofweek > 7)
                dayofweek -= 7;
            LSTVUDentists.Items.Clear();
            var result = Transaction.GetDoctorPresentTime(weekDay: dayofweek.ToString());
            for (int i = 0; i < result.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem((string)result.Rows[i]["FNamedentist"]);

                lvi.SubItems.Add((string)result.Rows[i]["LNamedentist"]);

                lvi.SubItems.Add(((decimal)result.Rows[i]["IDdentist"]).ToString());

                LSTVUDentists.Items.Add(lvi);
            }
        }


        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MessageTypeChanger(object sender, EventArgs e)
        {
            CMBXDraftMessage.Enabled = RDBTNDraftMessage.Checked;

            TXTBXMessageText.Enabled = RDBTNCustomMessage.Checked;
        }

        private void YearSelected(object sender, EventArgs e)
        {
            //try {
            //    LBLYear.Text = LSTVUYear.SelectedItems[0].Text;
            //}
            //catch
            //{
            //}
        }

        private void MonthSelectChange(object sender, EventArgs e)
        {
            //try
            //{
            //    LBLMonth.Text = LSTVUMonth.SelectedItems[0].Text;

            //    int month = int.Parse(LSTVUMonth.SelectedItems[0].Text.Split('-')[0]);

            //    int DentistID= int.Parse(((string)(comboBox1.SelectedItem)).Split(',')[0]);

            //    //@"SELECT  [R_his].[dbo].[Infodentist].FNamedentist
            //    //                                            ,[R_his].[dbo].[Infodentist].LNamedentist
            //    //                                            ,[R_his].[dbo].[Infodentist].IDdentist
            //    //                                            ,[R_his].[dbo].[DentistPresentTime].[WeekDay]
            //    //                                            ,[R_his].[dbo].[DentistPresentTime].[StartFromTime]
            //    //                                            ,[R_his].[dbo].[DentistPresentTime].[ToEndTime]
            //    //                                             FROM [R_his].[dbo].[Infodentist]
            //    //                                            JOIN [R_his].[dbo].[DentistPresentTime]
            //    //                                            ON [R_his].[dbo].[Infodentist].IDdentist=[R_his].[dbo].[DentistPresentTime].DentistID
            //    //                                            WHERE Active='1'
            //    //                                            AND [R_his].[dbo].[Infodentist].IDdentist='"+DentistID.ToString()+"'"
            //    int[] presentDay = new int[7];
            //    var result = new DatabaseManager().GetData(@"Select [R_his].[dbo].[DentistPresentTime].[WeekDay]
            //                                                FROM   [R_his].[dbo].[DentistPresentTime]                                           
            //                                                WHERE Active='1' AND [R_his].[dbo].DentistPresentTime.DentistID='"+DentistID.ToString()+"'");

            //    for (int i = 0; i < result.Rows.Count; i++)
            //    {
            //        presentDay[(byte)result.Rows[i][0]] =1 ;
            //    }
            //    int dayinmonth;
            //    if (month > 6)
            //        dayinmonth = 30;
            //    else
            //        dayinmonth = 31;
            //    LSTVUPresentDay.Items.Clear();

            //    for (int i = 1; i <=dayinmonth; i++)
            //    {
            //        byte dayofweek =(byte) PersianDateTime.GetDatOfWeek(new PersianDateTime(int.Parse(LBLYear.Text), month, i));
            //        if (presentDay[dayofweek] == 1)
            //        {
            //            ListViewItem PresentDayView = new ListViewItem(string.Format("{0}-{1}", i,
            //                PersianDateTime.WeekDayNames[dayofweek]));
            //            LSTVUPresentDay.Items.Add(PresentDayView);
            //        }
            //    }

            //    int Month = int.Parse(((string)(LSTVUMonth.SelectedItems[0].Text)).Split('-')[0]);

            //    int dayofWeek = PersianDateTime.GetDatOfWeek(new PersianDateTime(22, 2, 1396));
            //}
            //catch (Exception)
            //{

            //}
        }
        private void DaySelectChange(object sender, EventArgs e)
        {
            try
            {
                //LBLDay.Text = LSTVUPresentDay.SelectedItems[0].Text;
            }
            catch (Exception)
            {

            }
        }
        /***********************************************************/
#if DEBUG
        RobotManager _RobotConnection = new RobotManager("486336281:AAGaj4N7VBG1F3OW9kyxlvFPqt6LcEBjpy8");//
#else
        RobotManager _RobotConnection = new RobotManager("495512196:AAEEFp8bS53i9LJiIfSxgkMPblKHOXrZ5oo");//("486336281:AAGaj4N7VBG1F3OW9kyxlvFPqt6LcEBjpy8");//
#endif
        private void StartBot()
        {
        }

        private async void BTNSendMessage_Click(object sender, EventArgs e)
        {
            await _RobotConnection.Bot.SendTextMessageAsync(119549458, TXTBXFrom.Text + ":\r\n" + TXTBXMessageText.Text);
        }

        /***********************************************************/
        public void PatientDataGridViewUpdate()
        {
            var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    ,[TelQuick]
                                    ,[date_create]
                                    FROM [InfoSick]ORDER BY date_create DESC "
                          );
            DTGVPatientName.DataSource = result;
        }

        public void PatientQueTimeReserve_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n;
                bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);

                if (isNumeric)
                {
                    searchPatintProfileNormal(null, ((TextBox)sender).Text);
                }
                else
                    searchPatintProfileNormal(((TextBox)sender).Text, null);

            }
        }

        void searchPatintProfileNormal(string LName = null, string FileID = null)
        {
            if (LName != null)
            {
                var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    ,[date_create]
                                    ,[TelQuick]
                                    FROM [InfoSick]" +
                                        string.Format("WHERE {0} LIKE N'%{1}%'", "LNamesick", LName) +
                                    "ORDER BY date_create DESC ");
                DTGVPatientName.DataSource = result;
            }
            else if (FileID != null)
            {
                var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    ,[TelQuick]
                                    ,[date_create]
                                    FROM [InfoSick]" + string.Format("WHERE {0} = '{1}'", "IDsick", FileID) +
                                    "ORDER BY date_create DESC "
                                            );

                DTGVPatientName.DataSource = result;
            }
        }

        private void TXTBXNameOrFileID_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);

            if (isNumeric)
            {
                ((TextBox)sender).RightToLeft = RightToLeft.No;
                return;
            }
            else
                ((TextBox)sender).RightToLeft = RightToLeft.Yes;
            if (((TextBox)sender).Text.Length < 3)
                return;
            else
                searchPatintProfileNormal(((TextBox)sender).Text, null);
        }
        public int SelectDateTime { get; set; }
        private void TXTBXPresentFrom_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendarX2_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            UpdateDoctorList(monthCalendarX2.GetSelectedDateInDateTime());
        }

        private void BTNRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            try
            {
                string ToothNo = simpleQuadrant1.ToothId;
                string[] servicedetail = ((string)(CMBBXTreatmentPlan.SelectedItem)).Split(',');
                int DrID = int.Parse((string)LSTVUDentists.SelectedItems[0].SubItems[2].Text);
                string pid = ((decimal)DTGVPatientName.SelectedRows[0].Cells["IDsick"].Value).ToString();
                DateTime Desiredtime = monthCalendarX2.GetSelectedDateInDateTime();
                Desiredtime = new DateTime(Desiredtime.Year, Desiredtime.Month, Desiredtime.Day, (int)NMRCHour.Value, (int)NMRCMin.Value, 0);
                //if (!Transaction.RegisterVisitTime(DrID
                //                                 , servicedetail[1]
                //                                 , Desiredtime
                //                                 , false
                //                                 , 1
                //                                 , int.Parse(servicedetail[0])
                //                                 , pid
                //                                , ToothNo))
                //{
                //    return;
                //}

                DateTime From = monthCalendarX2.GetSelectedDateInDateTime();
                From = new DateTime(From.Year, From.Month, From.Day, 0, 0, 0);
                DateTime To = new DateTime(From.Year, From.Month, From.Day, 23, 59, 59);

                DataGridViewVisitTimeUpdate(From, To, DrID, status: 1);

                int TelegId = Transaction.GetTelegramID(DrID);

                if (TelegId < 0)
                    return;
                string toothMap = simpleQuadrant1.ToothMap;

                _RobotConnection.SendMessage(TelegId, "ثبت نوبت جدید:\r\n" +
                                                    "نام خدمت: " + servicedetail[1] +
                                                    "\r\n تاریخ :" + monthCalendarX2.GetSelectedDateInPersianDateTime().ToStringFormat("yyyy/MM/dd") + "\r\n"
                                                    + PersianDateTime.GetDayOfWeekName(monthCalendarX2.GetSelectedDateInDateTime()) + "  " +
                                                    string.Format("{0:00}:{1:00}", NMRCHour.Value, NMRCMin.Value)
                                                    + "\r\n"
                                                    + "دندان: " + "\r\n" + toothMap
                                                    + "بیمار: "
                                                    + DTGVPatientName.SelectedRows[0].Cells["FNamesick"].Value.ToString() + " "
                                                    + DTGVPatientName.SelectedRows[0].Cells["LNamesick"].Value.ToString() + "\r\n"
                                                    + "ش.پ: " + pid);
            }
            catch { }
        }


        public void RegisterNewService(int ServiceID, int DrID, string ServiceDetail, DateTime DesiredTime)
        {

        }

        private void EVNTDrSelected(object sender, ItemCheckedEventArgs e)
        {
            //string[] servicedetail = ((string)(CMBBXTreatmentPlan.SelectedItem)).Split(',');
            //int DoctorID = int.Parse((string)LSTVUDentists.SelectedItems[0].SubItems[2].Text);
            //DateTime From = monthCalendarX2.GetSelectedDateInDateTime();
            //From = new DateTime(From.Year, From.Month, From.Day, 0, 0, 0);
            //DateTime To = new DateTime(From.Year, From.Month, From.Day, 23, 59, 59);

            //DataGridViewVisitTimeUpdate(DoctorID, From, To, 0, 1);
        }

        public void DataGridViewVisitTimeUpdate(DateTime From
                                                , DateTime To
                                                , int Doctorid = -1
                                                , int PatientID = -1
                                                , int status = -1)
        {
            throw new NotImplementedException();
            //var result = Transaction.GetReservedTime(DoctorID: Doctorid, From: From, To: To, status: status);
            //DTGRVUVisitTime.DataSource = result;
        }

        private void EVNTDrSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //string[] servicedetail = ((string)(CMBBXTreatmentPlan.SelectedItem)).Split(',');
            try
            {
                int DoctorID = int.Parse((string)LSTVUDentists.SelectedItems[0].SubItems[2].Text);
                DateTime From = monthCalendarX2.GetSelectedDateInDateTime();
                From = new DateTime(From.Year, From.Month, From.Day, 0, 0, 0);
                DateTime To = new DateTime(From.Year, From.Month, From.Day, 23, 59, 59);

                DataGridViewVisitTimeUpdate(Doctorid: DoctorID, From: From, To: To, status: 1);
            }
            catch (Exception ex) { //DTGRVUVisitTime.Rows.Clear();
                Console.WriteLine(ex.Message);
            }
        }

        private void CHKBXToday_CheckedChanged(object sender, EventArgs e)
        {
            TXTBXNameID.Text = "";
            searchPatintProfile();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NMRCMin.Value = int.Parse(LSTVUDefaultMinValue.SelectedItems[0].Text);
            }
            catch { }
        }

        private void SearchInTime(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CHKBXToday.Checked = false;
                CHKBXAll.Checked = false;
                CHKBXTomorrow.Checked = false;
                if (!persianDateTimeBox1.BadFormat)
                {
                    DateTime From = persianDateTimeBox1.SelectedDate;
                    From = new DateTime(From.Year, From.Month, From.Day, 0, 0, 0);
                    DateTime To = new DateTime(From.Year, From.Month, From.Day, 23, 59, 59);
                    searchPatintProfile(From: From, To: To);
                }
            }
        }

        private void LSTVUHourChangeEvent(object sender, EventArgs e)
        {
            //try
            //{
            //    NMRCHour.Value = int.Parse((string)listView2.SelectedItems[0].Text);
            //}
            //catch
            //{ }
        }

        private void BTNBrowse_Click(object sender, EventArgs e)
        {

            try {
                if (SelectSaveToFile.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.GetDirectoryName(SelectSaveToFile.FileName);
                    Settings.Default.PatientDocumentSavePath = path;
                    SaveToFileAddress.Text = path;
                    DermaDent.Properties.Settings.Default.Save();
                } } catch { }
        }



        public void CMBBXDoctorNameAndIDUPdate()
        {
            CMBBXDoctorNameAndID.Items.Clear();
            var result = Transaction.GetDoctorList();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                string s = string.Format("{0},{1} {2}", result.Rows[i]["IDdentist"], result.Rows[i]["FNameDentist"], result.Rows[i]["LNameDentist"]);
                CMBBXDoctorNameAndID.Items.Add(s);
            }
        }

        private void BTNRegisterPresentTime_Click(object sender, EventArgs e)
        {
            string DID = ((string)CMBBXDoctorNameAndID.SelectedItem).Split(',')[0];

            TimeSpan From = TimeSpan.Parse(MSKDTXTBXStartTime.Text);
            TimeSpan To = TimeSpan.Parse(MSKDTXTBXEndTime.Text);
            if (From > To)
            {
                MessageBox.Show("Start time could not be bigger than EndTime");
                return;
            }
            if (CHKBXLSTWeekDay.CheckedIndices.Count < 1)
            {
                MessageBox.Show("Please select at leasr 1 working day");
                return;
            }

            if (CHKBXLSTWeekDay.GetItemChecked(0)) // it is floating time
            {
                Transaction.registerDoctorPresentTime(DID, From, To, 0);
            }
            else
            {
                for (int i = 0; i < CHKBXLSTWeekDay.CheckedIndices.Count; i++)
                {
                    Transaction.registerDoctorPresentTime(DID, From, To, CHKBXLSTWeekDay.CheckedIndices[i]);
                }
            }

            int DoctorID = int.Parse(((string)CMBBXDoctorNameAndID.SelectedItem).Split(',')[0]);
            UpdateDoctorTimes(DoctorID);
        }

        private void CMBBXDoctorNameAndID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CHKBXLSTWeekDay.Enabled = true;
            MSKDTXTBXEndTime.Enabled = true;
            MSKDTXTBXStartTime.Enabled = true;
            BTNRegisterPresentTime.Enabled = true;
            int DoctorID = int.Parse(((string)CMBBXDoctorNameAndID.SelectedItem).Split(',')[0]);
            UpdateDoctorTimes(DoctorID);
        }

        public void UpdateDoctorTimes(int drid)
        {
            LSTVUDoctorTimes.Items.Clear();
            var result = Transaction.GetDoctorPresentTime(id: drid.ToString());
            for (int i = 0; i < result.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(((int)result.Rows[i]["id"]).ToString());
                lvi.SubItems.Add((string)result.Rows[i]["FNameDentist"]);
                lvi.SubItems.Add((string)result.Rows[i]["LNameDentist"]);
                lvi.SubItems.Add(PersianDateTime.WeekDayNames[((byte)result.Rows[i]["WeekDay"])]);
                lvi.SubItems.Add(((TimeSpan)result.Rows[i]["StartFromTime"]).ToString("hh':'mm"));
                lvi.SubItems.Add(((TimeSpan)result.Rows[i]["ToEndTime"]).ToString("hh':'mm"));
                LSTVUDoctorTimes.Items.Add(lvi);
            }
        }

        private void BTNPatientProfile_Click(object sender, EventArgs e)
        {
            var LastFile = Transaction.GetLastPatient();
            //FRMPatientProfileManager patientProfile = new FRMPatientProfileManager(LastFile.FileID);
            FRMEditUserProfile patientProfile = new FRMEditUserProfile(LastFile.FileID);
            patientProfile.Show();
        }
        int selecteddocumentIndex = -1;
        private void GetUserFileList(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selecteddocumentIndex = DocumentList.HitTest(e.X, e.Y).RowIndex;
                if (selecteddocumentIndex >= 0)
                {

                }
            }
        }
        //public void searchPatintProfileByIDDoc(string NationalCode)
        //{
        //    var result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
        //                            ,[FNamesick]
        //                            ,[LNamesick]
        //                            ,[meliCode]
        //                            ,[Birthday]
        //                            ,[Tel]
        //                            FROM[R_his].[dbo].[InfoSick]" + string.Format("WHERE {0} ={1}", "meliCode ", NationalCode) +
        //                            "ORDER BY date_create DESC "
        //                  );
        //    DocumentList.DataSource = result;
        //}

        //private void SearchByTextDoc(object sender, EventArgs e)
        //{
        //    if (((TextBox)sender).Text.Trim().Length == 0)
        //        DefaultPatientQue();
        //    if (((TextBox)sender).Text.Trim().Length < 3)
        //        return;
        //    int n;
        //    bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);
        //    if (isNumeric)
        //        return;
        //    if (!isNumeric)
        //    {
        //        searchPatintProfile(((TextBox)sender).Text, null);
        //    }
        //}
        /***********************************************************/
        private ImageViewer m_ActiveImageViewer;
        public delegate void ThumbnailImageEventHandler(object sender, ThumbnailImageEventArgs e);
        private ImageDialog m_ImageDialog;

        private void m_Controller_OnAdd(object sender, ThumbnailControllerEventArgs e)
        {
            this.AddImage(e.ImageFilename);
            this.Invalidate();
        }

        private void m_Controller_OnEnd(object sender, ThumbnailControllerEventArgs e)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(new ThumbnailControllerEventHandler(m_Controller_OnEnd), sender, e);
            }
        }
        public void InitImageViewer()
        {
            m_ImageDialog = new ImageDialog();

            m_AddImageDelegate = new DelegateAddImage(this.AddImage);

            m_Controller = new ThumbnailController();
            m_Controller.OnAdd += new ThumbnailControllerEventHandler(m_Controller_OnAdd);
            m_Controller.OnEnd += new ThumbnailControllerEventHandler(m_Controller_OnEnd);
        }

        private ThumbnailController m_Controller;

        private int ImageSize
        {
            get
            {
                return (64 * 2);// * (this.trackBarSize.Value + 1));
            }
        }
        delegate void DelegateAddImage(string imageFilename);
        private DelegateAddImage m_AddImageDelegate;
        
        private void AddImage(string imageFilename)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(m_AddImageDelegate, imageFilename);
            }
            else
            {
                int size = ImageSize;

                ImageViewer imageViewer = new ImageViewer();
                imageViewer.Dock = DockStyle.Bottom;
                imageViewer.LoadImage(imageFilename, 256, 256);
                imageViewer.Width = size;
                imageViewer.Height = size;
                imageViewer.IsThumbnail = true;
                imageViewer.MouseDoubleClick += new MouseEventHandler(imageViewer_MouseClick);

                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Clear();
                cm.MenuItems.Add("حذف", new EventHandler(RemoveSelectedImage));
                //cm.MenuItems.Add("انتقال");
                //cm.MenuItems.Add("نمایش");

                imageViewer.ContextMenu = cm;
                //this.OnImageSizeChanged += new ThumbnailImageEventHandler(imageViewer.ImageSizeChanged);
                this.PatientImageBrowserPanel.Controls.Add(imageViewer);
            }
        }

        private void RemoveSelectedImage(object sender, EventArgs e)
        {
            try
            {
                this.PatientImageBrowserPanel.Controls.Remove((ImageViewer)(((MenuItem)sender).GetContextMenu().SourceControl));
                File.Delete(((ImageViewer)(((MenuItem)sender).GetContextMenu().SourceControl)).ImageLocation);
            }
            catch
            {

            }
        }
        string imageLocation;
        private void imageViewer_MouseClick(object sender, MouseEventArgs e)
        {

            imageLocation = ((ImageViewer)sender).ImageLocation;
            if (m_ActiveImageViewer != null)
            {
                m_ActiveImageViewer.IsActive = false;
            }

            m_ActiveImageViewer = (ImageViewer)sender;
            m_ActiveImageViewer.IsActive = true;

            if (m_ImageDialog.IsDisposed) m_ImageDialog = new ImageDialog();
            if (!m_ImageDialog.Visible) m_ImageDialog.Show();

            m_ImageDialog.SetImage(m_ActiveImageViewer.ImageLocation);           
            m_ImageDialog.FormClosed+=new FormClosedEventHandler(HandleFormClose);
        }

        private void HandleFormClose(object sender, FormClosedEventArgs e)
        {
            
        }

        public class ThumbnailImageEventArgs : EventArgs
        {
            public ThumbnailImageEventArgs(int size)
            {
                this.Size = size;
            }

            public int Size;
        }

        private void BTNShowCashier_MouseClick(object sender, EventArgs e)
        {
            FRMCashier cashier = new FRMCashier(0);
            cashier.Show();
        }

        private void DocumentList_SelectionChanged(object sender, EventArgs e)
        {
            if (DocumentList.SelectedRows.Count <= 0)
                return;
            var temp = GetUserDocument(DocumentList.SelectedRows[0].Cells[0].Value.ToString());
            updatePatientDocumentList(temp.GetUserFilelist());

            LBLIDCode.Text = DocumentList.SelectedRows[0].Cells[0].Value.ToString();
            LBLPatientName.Text = (string)DocumentList.SelectedRows[0].Cells[1].Value + " " + (string)DocumentList.SelectedRows[0].Cells[2].Value;
            
            this.PatientImageBrowserPanel.Controls.Clear();
            
            m_Controller.AddFolder(temp.UserPath);
        }

        private DocumentManager GetUserDocument(string id)
        {
            string roothPath = DermaDent.Properties.Settings.Default._UserDocumentRootPath;
            DocumentManager dm= new DocumentManager(roothPath, id);
            return dm;
        }
        public void updatePatientDocumentList(string[] files)
        {
            int i = 1;
            LSTVUPatientDocumentList.Items.Clear();
            foreach (string f in files)
            {
                string raw_filename = System.IO.Path.GetFileName(f);
                ListViewItem lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(raw_filename);
                LSTVUPatientDocumentList.Items.Add(lvi);
                i++;
            }
        }

        private void BTNInventory_Click(object sender, EventArgs e)
        {
            FRMCharge InventoryFactor = new FRMCharge();
            InventoryFactor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMTreatmentReport p = new FRMTreatmentReport(0);
            p.ShowDialog();
        }

        private void گزارشپروندهبیمارانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMUserProfileList upl= new FRMUserProfileList();
            upl.ShowDialog();
        }
    }
}
