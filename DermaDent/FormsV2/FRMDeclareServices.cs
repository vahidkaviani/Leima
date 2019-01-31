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
    public partial class FRMDeclareServices : Form
    {
        public FRMDeclareServices()
        {
            InitializeComponent();
            DTGServices.AutoGenerateColumns = false;
            //UpdateServiceList();
        }

        private void ChangeNewSwitch(object sender, EventArgs e)
        {
            RadioButton b = (RadioButton)sender;
            if (b.Name == RDBTNEdit.Name)
            {
                RDBRNNew.Checked = !RDBTNEdit.Checked;
            }
            if (b.Name == RDBRNNew.Name)
                RDBTNEdit.Checked = !RDBRNNew.Checked;

            if (RDBRNNew.Checked == true)
            {
                TXTBXEditCode.Visible = false;
                LBLEditCode.Visible = false;
                TXTBXNewCode.Enabled = true;
            }
            else
            {
                TXTBXEditCode.Visible = true;
                LBLEditCode.Visible = true;
                TXTBXNewCode.Enabled = false;
            }
        }

        void UpdateServiceList()
        {
            DTGServices.DataSource = Transaction.GetServicesListAndInfo();
        }
        private void BTNICRegister_Click(object sender, EventArgs e)
        {
   
        }
        int SelectedItemListview = -1;
        private void ManageContextMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedItemListview = DTGServices.HitTest(e.X, e.Y).RowIndex;

                if (SelectedItemListview >= 0)
                {
                    ContextMenu m = new ContextMenu();
                    //m.MenuItems.Add("ثبت گزارش درمان", RegisterTreatmentPlanclick);
                    //m.MenuItems.Add("غیبت", PatientAbsentclick);
                    //m.MenuItems.Add("کنسل بیمار", PatientCancelClick);
                    //m.MenuItems.Add("کنسل پزشک", DoctorCancelclick);
                    m.MenuItems.Add("حذف", RemoveTimeclick);
                    m.Show(DTGServices, new Point(e.X, e.Y));
                }
            }
        }

        private void RemoveTimeclick(object sender, EventArgs e)
        {
           
        }
    }
}
