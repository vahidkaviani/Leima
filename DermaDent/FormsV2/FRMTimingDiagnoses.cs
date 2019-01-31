using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent.FormsV2
{
    public partial class FRMTimingDiagnoses : Form
    {
        public FRMTimingDiagnoses()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            UpdateDataGridView();
        }


        void UpdateDataGridView()
        {
            dataGridView1.DataSource = Transaction.GetDiagnosesList();
        }

        private void ICOAdd_Click(object sender, EventArgs e)
        {
            Transaction.CreatNewDiagnoses(TXTBXDiagnosesName.Text);
            TXTBXDiagnosesName.Text = string.Empty;
            UpdateDataGridView();
        }

        int SelectedItemListview = -1;
        private void HandleMousClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedItemListview = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (SelectedItemListview >= 0)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add("حذف", RemoveDiag);
                    //m.MenuItems.Add("ثبت گزارش درمان", RegisterTreatmentPlanclick);
                    //m.MenuItems.Add("غیبت", PatientAbsentclick);
                    //m.MenuItems.Add("کنسل بیمار", PatientCancelClick);
                    //m.MenuItems.Add("کنسل پزشک", DoctorCancelclick);
                    //m.MenuItems.Add("حذف", RemoveTimeclick);
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void RemoveDiag(object sender, EventArgs e)
        {
            int DiagCode = (int)dataGridView1.Rows[SelectedItemListview].Cells[0].Value;
            Transaction.DeleteDiag(DiagCode);
            UpdateDataGridView();
        }
    }
}
