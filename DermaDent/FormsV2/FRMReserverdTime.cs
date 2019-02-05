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

    public partial class FRMReserverdTime : Form
    {
        public static string[] StatusDetail = {""
                                                ,"در انتظار"
                                                ,"معالجه"
                                                ,"کنسل بیمار"
                                                ,"کنسل بخش"
                                                ,"حذف"
                                                ,"عدم ثبت"
                                                ,"غیبت" };
        public static Color[] statusColor = {Color.White
                                            ,Color.Black
                                            ,Color.Green
                                            ,Color.Orange
                                            ,Color.Blue
                                            ,Color.DimGray
                                            ,Color.Purple
                                            ,Color.Red};
        public FRMReserverdTime()
        {
            
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            panel1.Width = this.Width;
            panel1.Location=new Point(0,40);
            dataGridView1.Columns[6].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView1.Columns[7].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView1.Columns[8].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView1.Columns[9].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            persianDateTimeBox1.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            persianDateTimeBox2.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            UpdateTime();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (e.ColumnIndex ==12)// dgv.Columns["QueueNo"].Index)
                {
                    if (e.Value == null)
                        return;
                    short Status = (short)e.Value;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = statusColor[Status];
                    e.Value = StatusDetail[(short)e.Value];
                    if(Status==5)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                }
            }
            catch { }
            //if (e.ColumnIndex == 11)
            //{
            //    if(dataGridView1.Rows[e.RowIndex].
            //}
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            panel1.Width = this.Width;
            dataGridView1.Width = this.Width-25;
        }

        private void BTNICExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTime()
        {
            dataGridView1.DataSource = Transaction.GetReservedTime(persianDateTimeBox1.Text, persianDateTimeBox2.Text,OnlyAllocated:true);
        }
        int SelectedItemListview = -1;
        //private void RemovePresenttime(object sender, EventArgs e)
        //{
        //    int PresentTime = int.Parse(LSTVUDoctorTimes.Items[SelectedPresentTime].SubItems[0].Text);
        //    if (SelectedPresentTime >= 0)
        //    {
        //        Transaction.DisabledoctorPresentTime(ID: PresentTime);
        //        int DoctorID = int.Parse(((string)CMBBXDoctorNameAndID.SelectedItem).Split(',')[0]);
        //        UpdateDoctorTimes(DoctorID);
        //    }
        //}
        private void PatientAbsentclick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((decimal)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 7);
                UpdateTime();
            }
        }

        private void PatientCancelClick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 3);
                UpdateTime();
            }
        }

        private void DoctorCancelclick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {
                Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 4);
                UpdateTime();
            }
        }

        private void RemoveTimeclick(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["id"].Value))
            //    return;
            if (SelectedItemListview >= 0)
            {

                Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 5);
                UpdateTime();
            }
        }

        private void RegisterTreatmentPlanclick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty((string)dataGridView1.Rows[SelectedItemListview].Cells["PatientID"].Value))
                    return;
                if (SelectedItemListview >= 0)
                {
                    if (dataGridView1.Rows.Count < 0)
                        return;
                    Transaction.UpdateVisitTimeState((dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value).ToString(), 2);
                    FRMTreatmentReport frm = new FRMTreatmentReport(int.Parse((string)dataGridView1.Rows[SelectedItemListview].Cells["PatientID"].Value), (int)dataGridView1.Rows[SelectedItemListview].Cells["QueueNo"].Value);
                    UpdateTime();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
            
        }
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

        private void BTNICRegisterServices_Click(object sender, EventArgs e)
        {
            FRMPatientRespect fpr = new FRMPatientRespect("",PatientID: ((string)dataGridView1.Rows[SelectedItemListview].Cells["PatientID"].Value));
            fpr.MdiParent = this.MdiParent;
            fpr.Show();
        }

        private void BTNShowTimes_Click(object sender, EventArgs e)
        {
           UpdateTime();
        }
    }
}

