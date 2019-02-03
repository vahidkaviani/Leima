using DermaDent.FormsV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent
{
    public partial class FRMAllocatTime : Form
    {
        public FRMAllocatTime(string username)
        {
            InitializeComponent();
            DTGVReservedTimeList.Columns[8].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            DTGVReservedTimeList.Columns[9].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            DTGVReservedTimeList.Columns[10].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            DTGVReservedTimeList.Columns[11].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            farsiCalendar1.OnSelectedDayChanged += FarsiCalendar1_OnSelectedDayChanged;
            DTGVReservedTimeList.AutoGenerateColumns = false;
            persianDateTimeBox1.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            LBLWorkingUser.Text = string.Format("{0} {1}", "کار پذیرش :", username);
            updateTimeLists();
            DTGVReservedTimeList.CellFormatting += DTGVReservedTimeList_CellFormatting;
            CMBBXMonthNames.SelectedIndex = PersianDateTime.GetMonth(DateTime.Now) - 1;
            CMBBXDay.SelectedIndex = PersianDateTime.GetDayOfMonth(DateTime.Now) - 1;
            UpdateServiceName();
            DTGVReservedTimeList.CellValueChanged += DTGVReservedTimeList_CellValueChanged;
        }

        private void DTGVReservedTimeList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DTGVReservedTimeList.Columns[e.ColumnIndex].Name == "description")
            {
                string description = (DTGVReservedTimeList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                string pid = (DTGVReservedTimeList.Rows[e.RowIndex].Cells["pid"].Value.ToString());
                if (!LoadPatientInfo(pid))
                    return;
                Transaction.EditVisitTimeState((DTGVReservedTimeList.Rows[e.RowIndex].Cells["QueueNo"].Value.ToString()), desc: description);
                updateTimeLists();
            }
            if (DTGVReservedTimeList.Columns[e.ColumnIndex].Name == "pid")
            {
                
                string pid = (DTGVReservedTimeList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (!LoadPatientInfo(pid))
                    return;
                Transaction.EditVisitTimeState((DTGVReservedTimeList.Rows[e.RowIndex].Cells["QueueNo"].Value).ToString(), PatientID: pid, status: "1");
                updateTimeLists();
            }
            if (DTGVReservedTimeList.Columns[e.ColumnIndex].Name == "VisitTime")
            {

                string time = (DTGVReservedTimeList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                //if (!LoadPatientInfo(time))
                //    return;
                TimeSpan t = TimeSpan.Parse(time);
                Transaction.EditVisitTimeState((DTGVReservedTimeList.Rows[e.RowIndex].Cells["QueueNo"].Value).ToString(),t: t);
                updateTimeLists();
            }
        }

        void UpdateServiceName()
        {
            var v = Transaction.GetDiagnosesList();
            CMBBXServiceName.Items.Clear();
            for (int i = 0; i < v.Rows.Count; i++)
            {
                CMBBXServiceName.Items.Add(v.Rows[i]["NameDiagnosis"]);
            }
        }
        private void DTGVReservedTimeList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (e.ColumnIndex == dgv.Columns["Status"].Index)
                {
                    if (e.Value == null)
                        return;
                    short Status = (short)e.Value;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = FRMReserverdTime.statusColor[Status];
                    e.Value = FRMReserverdTime.StatusDetail[(short)e.Value];
                    if (Status == 5)
                        dgv.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                }
            }
            catch { }
        }
        bool IndexChangedAutomatically = false;
        private void FarsiCalendar1_OnSelectedDayChanged(object sender, EventArgs e)
        {
            IndexChangedAutomatically = true;
            persianDateTimeBox1.Text = farsiCalendar1.SelectedDate;
            CMBBXMonthNames.SelectedIndex = farsiCalendar1._PresentingMonth - 1;
            NUDYear.Value = farsiCalendar1._PresentingYear;
            CMBBXDay.SelectedIndex = farsiCalendar1._SelectedDay - 1;

            updateTimeLists();

        }
        void UpdateDoctorList()
        {

        }
        private void updateTimeLists(bool ViewDrTimes = false,int drId=-1,bool updateDrList=true)
        {
            if (ViewDrTimes)
            {
                var v = Transaction.GetReservedTime(farsiCalendar1.SelectedDate, farsiCalendar1.SelectedDate, DoctorID: drId);
                DTGVReservedTimeList.DataSource = v;
            }
            else if(DTGVReservedTimeList.Rows.Count>0)
                DTGVReservedTimeList.DataSource=null;

            if (!updateDrList)
                return;
            string query = string.Format(@"SELECT convert(varchar,DoctorID)+','+FNamedentist+' ' +LNamedentist AS Dentist,QCount
                                            FROM (
                                            SELECT DoctorID,COUNT(1) AS QCount
                                            FROM VisitTime AS test
                                            WHERE PersianDate BETWEEN '{0}' AND  '{1}' AND Status != '5'
                                            GROUP BY DoctorID
                                            ) AS QN
                                            JOIN Infodentist
                                            ON IDdentist=DoctorID", farsiCalendar1.SelectedDate, farsiCalendar1.SelectedDate);
            var drs= Transaction.ExecutSuctomQuery(query);
            GVQList.DataSource = drs;
            if (!ViewDrTimes&&drs.Rows.Count==1)
            {
                var v = Transaction.GetReservedTime(farsiCalendar1.SelectedDate, farsiCalendar1.SelectedDate, DoctorID: drId);
                DTGVReservedTimeList.DataSource = v;
            }
        }
        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BTNAllocatedTime_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRMAllAllocatedTime frmaat = new FRMAllAllocatedTime();
            frmaat.MdiParent = this.MdiParent;
            frmaat.Show();
        }

        private void BTNSearchTimeAllocatedPatient_Click(object sender, EventArgs e)
        {
            FRMSearchTimeAllocated frmsta = new FRMSearchTimeAllocated();
            frmsta.MdiParent = this.MdiParent;
            frmsta.Show();
        }

        private void BTNDefineTimes_Click(object sender, EventArgs e)
        {
            FRMTimeDivision ftd = new FRMTimeDivision();
            ftd.MdiParent = this.MdiParent;
            ftd.Show();
            updateTimeLists();
        }

        private void BTNPreviousMonth_Click(object sender, EventArgs e)
        {
            farsiCalendar1.PreviousMonth();
        }

        private void BTNNextMonth_Click(object sender, EventArgs e)
        {
            farsiCalendar1.NextMonth();
        }

        private void BTNSaveTime_Click(object sender, EventArgs e)
        {

            int drid;
            try
            {
                drid = int.Parse(((string)(doctorNameComboBox1.SelectedItem)).Split(',')[0]);
            }
            catch
            {
                MessageBox.Show("پزشک معالج؟");
                return;
            }
            if (string.IsNullOrEmpty(TXTBXFileID.Text))
                MessageBox.Show("شماره پرونده ؟");
            int hour = int.Parse(maskedTextBox1.Text.Split(':')[0]);
            int minut = int.Parse(maskedTextBox1.Text.Split(':')[1]);
            DateTime dt = new System.Globalization.PersianCalendar().ToDateTime(farsiCalendar1._PresentingYear, farsiCalendar1._PresentingMonth, farsiCalendar1._SelectedDay, hour, minut, 1, 1);
            Transaction.RegisterVisitTime(drid, CMBBXServiceName.SelectedItem.ToString(), persianDateTimeBox1.Text, TimeSpan.Parse(maskedTextBox1.Text), true, 1, CMBBXServiceName.SelectedIndex, TXTBXFileID.Text, "1,,,", null);
            updateTimeLists();
        }

        private void CheckPatientInfo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                LoadPatientInfo();
            else
                LBLLastName.Text = "";
        }
        private bool LoadPatientInfo(string pid=null)
        {
            if (pid == null)
                pid = TXTBXFileID.Text;
            if (string.IsNullOrEmpty(pid))
            {
                MessageBox.Show("شماره پرونده وارده صحیح  نمی باشد");
                return false;
            }
            var v = Transaction.GetPatientList(FileID: pid);
            if (v.Rows.Count < 1)
            {
                MessageBox.Show("شماره پرونده وارده صحیح  نمی باشد");
                return false;
            }
            else
            {
                LBLLastName.Text = (string)v.Rows[0]["FNameSick"] + " " + (string)v.Rows[0]["LNameSick"];
            }
            return true;
        }
        private void BTNSearchPatient_Click(object sender, EventArgs e)
        {
            FRMSearchPatient FSP = new FRMSearchPatient();
            FSP.ShowDialog();
            TXTBXFileID.Text = FSP._PatientID;
            FSP.Dispose();
            LoadPatientInfo();
        }

        private void CMBBXMonthNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IndexChangedAutomatically)
                return;
            farsiCalendar1.GoToDate((int)NUDYear.Value, CMBBXMonthNames.SelectedIndex + 1, CMBBXDay.SelectedIndex + 1);
            persianDateTimeBox1.Text = persianDateTimeBox1.Text.Substring(0, 5) + (CMBBXMonthNames.SelectedIndex + 1).ToString("00") + persianDateTimeBox1.Text.Substring(7, 3);
        }

        private void NUDYear_ValueChanged(object sender, EventArgs e)
        {
            farsiCalendar1.GoToDate((int)NUDYear.Value, CMBBXMonthNames.SelectedIndex + 1, CMBBXDay.SelectedIndex + 1);
            persianDateTimeBox1.Text = NUDYear.Value.ToString() + "/" + (CMBBXMonthNames.SelectedIndex + 1).ToString("00") + persianDateTimeBox1.Text.Substring(7, 3);
        }

        private void persianDateTimeBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string[] Data = persianDateTimeBox1.Text.Split('/');
                int year = int.Parse(Data[0]);
                int month = int.Parse(Data[1]);
                int day = int.Parse(Data[2]);
                farsiCalendar1.GoToDate(year, month, day);
            }
            catch
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("پرینتر یافت نشد.");
        }
        int SelectedItemListview = -1;
        private void HandleTimeContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedItemListview = DTGVReservedTimeList.HitTest(e.X, e.Y).RowIndex;

                if (SelectedItemListview >= 0)
                {
                    MenuItem mi = new MenuItem();
                    ContextMenu m = new ContextMenu();
                    m.RightToLeft = RightToLeft.Yes;
                    m.MenuItems.Add("تخصیص", Replace);
                    m.MenuItems.Add("انتقال به بیمار دیگر", Replace);
                    m.MenuItems.Add("ارسال پیامک", sendNotificationMessage);
                    //m.MenuItems.Add("غیبت", PatientAbsentclick);
                    m.MenuItems.Add("افزودن نوبت", createNewVisitTime);
                    m.MenuItems.Add("کنسل بیمار", PatientCancelClick);
                    //m.MenuItems.Add("انتقال / بریدن", ReAllocateTime);
                    //m.MenuItems.Add("چسباندن ", ReAllocateTime);
                    m.MenuItems.Add("کنسل پزشک", DoctorCancelclick);
                    m.MenuItems.Add("حذف", RemoveTimeclick);
                    m.Show(DTGVReservedTimeList, new Point(e.X, e.Y));
                }
            }
        }

        private void sendNotificationMessage(object sender, EventArgs e)
        {
            MessageBox.Show("کاربر گرامی\r\nبا عرض پوزش پنل ارسال پیامک شما فعال نیست", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void createNewVisitTime(object sender, EventArgs e)
        {
            string QueueID = DTGVReservedTimeList.Rows[SelectedItemListview].Cells["QueueNo"].Value.ToString();
            //string date= DTGVReservedTimeList.Rows[SelectedItemListview].Cells["QueueNo"].Value.ToString();
            var detail = Transaction.GetVisitTimeDetail(int.Parse(QueueID));
            TimeSpan t = (TimeSpan)detail.Rows[0]["TimeToVisit"];
            bool created = false;
            for (int i = 0; i < 10&&!created ; i++)
            {
                created = Transaction.RegisterVisitTime((int)detail.Rows[0]["DoctorID"], "", (string)detail.Rows[0]["PersianDate"], t, true, 1, 0, "0", "1,,,", DateTime.Now);
                t=t.Add(new TimeSpan(0, 1, 0));
            }
            updateTimeLists(true, -1, false);
        }

        private void ReAllocateTime(object sender, EventArgs e)
        {
            string name = (string)DTGVReservedTimeList.Rows[SelectedItemListview].Cells["PatientFirstName"].Value + " " + (string)DTGVReservedTimeList.Rows[SelectedItemListview].Cells["PatientLastName"].Value;
            string message = string.Format("{0} {1} {2} {3} {4} {5} {6}", "آبا می خواهید نوبت ", name, "به ساعت", maskedTextBox1.Text, "مورخ", persianDateTimeBox1.Text, "منتقل شود؟");
            MessageBox.Show(message, "توجه", MessageBoxButtons.YesNo);
        }

        private void PatientCancelClick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((DTGVReservedTimeList.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 3);
            }
        }

        private void DoctorCancelclick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((DTGVReservedTimeList.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 4);
            }
        }
        private void Replace(object sender, EventArgs e)
        {
            FRMSearchPatient FSP = new FRMSearchPatient();
            FSP.ShowDialog();
            if (FSP._PatientID != "-1")
            {
                TXTBXFileID.Text = FSP._PatientID;
                string PatientID = FSP._PatientID;
                LoadPatientInfo();
                Transaction.EditVisitTimeState((DTGVReservedTimeList.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), PatientID: PatientID, status: "1");
                updateTimeLists();
            }
            FSP.Dispose();

        }

        private void RemoveTimeclick(object sender, EventArgs e)
        {
            if (SelectedItemListview >= 0)
            {

                //Transaction.UpdateVisitTimeState((DTGVReservedTimeList.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 5);
                Transaction.EditVisitTimeState((DTGVReservedTimeList.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(),PatientID:"0" , status: "1");
                updateTimeLists();
            }
        }

        private void CMBBXDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IndexChangedAutomatically)
            {

                farsiCalendar1.GoToDate((int)NUDYear.Value, CMBBXMonthNames.SelectedIndex + 1, CMBBXDay.SelectedIndex + 1);
                persianDateTimeBox1.Text = NUDYear.Value.ToString() + "/" + (CMBBXMonthNames.SelectedIndex + 1).ToString("00/") + (CMBBXDay.SelectedIndex + 1).ToString("00");
            }
            else IndexChangedAutomatically = false;
        }

        private void DrSelected(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SelectedItemListview = GVQList.HitTest(e.X, e.Y).RowIndex;
                if (SelectedItemListview < 0)
                    return;
                int drId = int.Parse(GVQList.Rows[SelectedItemListview].Cells[0].Value.ToString().Split(',')[0]);
                updateTimeLists(true, drId, false);
            }
        }
    }
}
