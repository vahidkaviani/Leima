using DermaDent.FormsV2;
using DSoftShopcheeBot;
using number2Text;
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
    public partial class FRMCashier : Form
    {
        public int PatientID { get; set; }
        AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
        public FRMCashier(int pid=-1)
        {
            InitializeComponent();
            if (pid == -1)
            {
                UpdatePatientList();
                return;
            }
            InitForm(pid);
            PatientID = pid;
            GetPatientCheckout();
        }


        public void InitForm(int patientID)
        {
            this.PatientID = patientID;
            var result = new DatabaseManager().GetData(@"SELECT  [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    FROM [InfoSick] WHERE IDsick='" + patientID.ToString() + "'" +
                                    "ORDER BY date_create DESC");

            if (result.Rows.Count > 0)
            {
                LBLName.Text = (string)result.Rows[0]["FNamesick"];
                LBLFamily.Text = (string)result.Rows[0]["LNamesick"];
            }
            LBLFileId.Text = patientID.ToString();
            var pc = new System.Globalization.PersianCalendar();
            LBLDateTime.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
            
            TXTBXRemain.Text = Transaction.GetPaiaibleValue(null, null, PID: PatientID).ToString();
        }

        public void GetPatientCheckout()
        {
            var result = Transaction.GetPatientCheckout(null, null, PID: PatientID);
            DTGVUUserPayment.DataSource = result;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(TXTBXPaidValue.Text) && e.KeyChar == '0')
                e.Handled = true;

            else if (!char.IsNumber(e.KeyChar)&&!char.IsControl(e.KeyChar))
                e.Handled = true;
           
        }

        private void BTNRegisterPaiment_Click(object sender, EventArgs e)
        {

        }

        private void TXTBXPaidValue_TextChanged(object sender, EventArgs e)
        {
            int val;

            if (!int.TryParse(TXTBXPaidValue.Text.Replace(",",""), out val))
                return;
            string result = new PNumberTString().num2str((val/10).ToString());
            LBLPaidInPersian.Text = result + " تومان";
            TXTBXPaidValue.Text = val.ToString("#,#");
            TXTBXPaidValue.SelectionStart = TXTBXPaidValue.Text.Length;
        }

        private void BTNICExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTBXPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //acsc.Clear();
            //var plist = Transaction.GetPatientList(Name: TXTBXPatientID.Text+e.KeyChar);
            //for (int i = 0; i < plist.Rows.Count; i++)
            //{
            //    acsc.Add(plist.Rows[i]["fnamesick"].ToString()+" "+ plist.Rows[i]["lnamesick"].ToString());
            //}
        }

        private void UpdatePatientList(string name = null, string id = null)
        {
            LSTVUPatient.Items.Clear();
            var result = Transaction.GetPatientList(FirstName: name, FileID: id);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((string)result.Rows[i]["LNameSick"]+" "+(string)result.Rows[i]["FNameSick"]);
                item.SubItems.Add(((decimal)result.Rows[i]["IDsick"]).ToString());
                LSTVUPatient.Items.Add(item);
            }
        }

        private void TXTBXPatientID_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Trim().Length == 0)
                UpdatePatientList();

            if (((TextBox)sender).Text.Trim().Length < 3)
                return;

            int n;
            bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);
            if (isNumeric)
                UpdatePatientList(id: n.ToString());
            if (!isNumeric)
            {
                UpdatePatientList(((TextBox)sender).Text, null);
            }
        }

        private void LSTVUPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            try
            {
                if (int.TryParse(LSTVUPatient.SelectedItems[0].SubItems[1].Text, out val))
                {
                    InitForm(val);
               
                    PatientID = val;
                    GetPatientCheckout();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BTNDevideUserPrePayment(object sender, EventArgs e)
        {
            FRMRepayment FRMRP = new FRMRepayment(LBLFileId.Text);
            FRMRP.MdiParent = this.MdiParent;
            FRMRP.Show();
        }
    }
}
