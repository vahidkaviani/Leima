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
            UpdateServiceList();
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
                BTNICRegister.Text = "ثبت خدمت";
            }
            else
            {
                TXTBXEditCode.Visible = true;
                LBLEditCode.Visible = true;
                TXTBXNewCode.Enabled = false;
                BTNICRegister.Text = "اصلاح خدمت";
            }
        }

        void UpdateServiceList()
        {
            DTGServices.DataSource = Transaction.GetServicesListAndInfo(null);
        }
        private void BTNICRegister_Click(object sender, EventArgs e)
        {
            if (RDBRNNew.Checked)
            {
                RegisterNewService();
            }
            else if (RDBTNEdit.Checked)
            {
                UpdateServiceInfo();
            }
        }

        private void UpdateServiceInfo()
        {
            int servicecode;
            bool isnummeric = int.TryParse(TXTBXNewCode.Text, out servicecode);
            if (!isnummeric)
                return;
            string ServiceName = TXBXServiceName.Text;
            if (ServiceName.Trim().Length < 1)
                return;

            string latinaName = TXBXLatinName.Text;
            string desc = TXBXDescription.Text;
            int subGroup = comboBox1.SelectedIndex;
            int InsuranceServiceType = CMBBXServiceInsuranceType.SelectedIndex;
            int CenterId = 1;
            if (Transaction.GetServicesListAndInfo(servicecode).Rows.Count <1)
            {
                MessageBox.Show("کد ناموجود");
                return;
            }
            Transaction.EditService(servicecode, ServiceName, latinaName, desc, subGroup, InsuranceServiceType, CenterId);
        }

        private void RegisterNewService()
        {
            int servicecode;
            bool isnummeric = int.TryParse(TXTBXNewCode.Text, out servicecode);
            if (!isnummeric)
                return;
            string ServiceName = TXBXServiceName.Text;
            if (ServiceName.Trim().Length < 1)
                return;

            string latinaName = TXBXLatinName.Text;
            string desc = TXBXDescription.Text;
            int subGroup = comboBox1.SelectedIndex;
            int InsuranceServiceType = CMBBXServiceInsuranceType.SelectedIndex;
            int CenterId = 1;
            if (Transaction.GetServicesListAndInfo(servicecode).Rows.Count > 0)
            {
                MessageBox.Show("کد تکراری");
                return;
            }
            Transaction.CreateNewService(servicecode,ServiceName,latinaName,desc,subGroup,InsuranceServiceType,CenterId);
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
                    m.MenuItems.Add("حذف", RemoveTimeclick);
                    m.MenuItems.Add("اصلاح", EditService);
                    m.Show(DTGServices, new Point(e.X, e.Y));
                }
            }
        }

        private void EditService(object sender, EventArgs e)
        {
        }

        private void RemoveTimeclick(object sender, EventArgs e)
        {
           
        }

        private void LoadInfo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                int servicecode;
                bool isnummeric = int.TryParse(TXTBXEditCode.Text, out servicecode);
                if (!isnummeric)
                    return;
                var v=Transaction.GetServicesListAndInfo(servicecode);
                if (v.Rows.Count > 0)
                {
                    if (v.Rows[0]["NameService"] != DBNull.Value)
                        TXBXServiceName.Text = (string)v.Rows[0]["NameService"];
                    if (v.Rows[0]["NodePtr"] != DBNull.Value)
                        TXBXDescription.Text = (string)v.Rows[0]["NodePtr"];
                    if (v.Rows[0]["nameservice_latin"] != DBNull.Value)
                        TXBXLatinName.Text = (string)v.Rows[0]["nameservice_latin"];
                    if (v.Rows[0]["IDSub"] != DBNull.Value)
                        comboBox1.SelectedIndex= (int)(decimal)v.Rows[0]["IDSub"];
                    TXTBXNewCode.Text = servicecode.ToString();

                }
            }
        }
    }
}
