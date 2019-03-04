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
    public partial class FRMPatientInfo : Form
    {
        public static Color[] cl = new Color[] { Color.Red, Color.SpringGreen, Color.CornflowerBlue, Color.Gold, Color.DarkViolet,Color.Yellow ,Color.White};
        string workingUserForm="";
        public FRMPatientInfo(string id_user="anonymous")
        {
            InitializeComponent();

            CMBBXColor.DrawItem += new DrawItemEventHandler(CMBBXColor_DrawItem);
            try
            {
                LBLLastID.Text = Culture.ConvertNumerals(Transaction.GetLastPatient().FileID);
            }
            catch { }
            workingUserForm = id_user;

            for (int i = 0; i < cl.Length; i++)
                CMBBXColor.Items.Add((i + 1).ToString());
            TXTBXRegisterDateTime.Text = PersianDateTime.GetPersianDate(DateTime.Now);
        }

      

        private void BTNExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CMBBXColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string color = this.CMBBXColor.SelectedItem.ToString();
            this.PatientColorPanel.BackColor = cl[int.Parse(color) - 1];
        }
        private void CMBBXColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 12, FontStyle.Regular);
                Color c = cl[int.Parse(n) - 1];
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 20, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }
        public void SetLastID()
        {

        }
        private void SwitchLanguageOnEnter(object sender, EventArgs e)
        {
            SetKeyboardLayout(GetInputLanguageByName("fa"));
        }
        private void ReturnLanguageOnLeave(object sender, EventArgs e)
        {
            SetKeyboardLayout(GetInputLanguageByName("en"));
        }
        public static InputLanguage GetInputLanguageByName(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.IetfLanguageTag.ToLower().StartsWith(inputName))
                {
                    return lang;
                }
            }
            return null;
        }
        private void SetKeyboardLayout(InputLanguage layout)
        {
            InputLanguage.CurrentInputLanguage = layout;
        }

        private void BTNICRegisterDisease_Click(object sender, EventArgs e)
        {
            FRMState frms = new FRMState();
            frms.ShowDialog();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (EditingMode)
            {
                UpdateUserProfile();
                EditingMode = false;
                TXTBXFileID.ReadOnly = false;
                ResetForm();
            }
            else if (Register())
                MessageBox.Show("با موفقیت ثبت شد");
            else
                MessageBox.Show("خطا");
        }

        //__________________________________________
        public void ResetForm()
        {
            TXTPatientFirstName.Text = string.Empty;
            TXTPatientLastName.Text = string.Empty;
            TXTBXHomeAddress.Text = string.Empty;
            TXTPatientNationalID.Text = string.Empty;
            TXTBXCellPhone.Text = string.Empty;
            TXTPatientFatherName.Text = string.Empty;
            TXTPatientBirthDay.Text = string.Empty;
            TXTBXFileID.Text = string.Empty;
            TXTPatientBirthPlace.Text = string.Empty;
            TXTTel.Text = string.Empty;
            TXTBXRelation.Text = string.Empty;
            TXTOfficeAddress.Text = string.Empty;
            PatientColorPanel.BackColor= SystemColors.AppWorkspace;
            CMBBXColor.SelectedIndex = 0;
        }
        public bool Register()
        {
            try
            {
                if (CMBBXColor.SelectedIndex == -1)
                    CMBBXColor.SelectedIndex = 0;
                string gender = "زن";
                int Maried = RDBTNMaried.Checked ? 1 : 0;
                if (RDBTNMale.Checked)
                    gender = "مرد";
                Transaction.NewPatient(TXTPatientFirstName.Text,
                    TXTPatientLastName.Text,
                   TXTBXFileID.Text,
                   gender,
                   TXTPatientBirthDay.Text,
                   TXTBXHomeAddress.Text,
                   TXTBXCellPhone.Text,
                   TXTTel.Text,
                   TXTPatientNationalID.Text,
                   TXTPatientFatherName.Text,
                   TXTBXRegisterDateTime.Text,
                   TXTBXRelation.Text,//CMBBXReagent.Text
                   MariageState: Maried,
                   id_user: workingUserForm,
                   comment: CMBBXColor.SelectedItem.ToString(),
                   jobLocation:TXTOfficeAddress.Text,
                   BirthPlace:TXTPatientBirthPlace.Text
                   );
                ResetForm();
                return true;
            }
            catch (Exception ex)
            {
#if DEBUG
                    MessageBox.Show(ex.Message);
#endif
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool UpdateUserProfile()
        {
            try
            {
                if (CMBBXColor.SelectedIndex == -1)
                    CMBBXColor.SelectedIndex = 0;
                string gender = "زن";
                int Maried = RDBTNMaried.Checked ? 1 : 0;
                if (RDBTNMale.Checked)
                    gender = "مرد";
                Transaction.UpdatePatient(TXTPatientFirstName.Text,
                    TXTPatientLastName.Text,
                   TXTBXFileID.Text,
                   gender,
                   TXTPatientBirthDay.Text,
                   TXTBXHomeAddress.Text,
                   TXTBXCellPhone.Text,
                   TXTTel.Text,
                   TXTPatientNationalID.Text,
                   TXTPatientFatherName.Text,
                   TXTBXRegisterDateTime.Text,
                   TXTBXRelation.Text,//CMBBXReagent.Text
                   MariageState: Maried,
                   id_user: workingUserForm,
                   comment: CMBBXColor.SelectedItem.ToString(),
                   jobLocation: TXTOfficeAddress.Text,
                   BirthPlace: TXTPatientBirthPlace.Text
                   );
                ResetForm();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
 
        private void TextBoxEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }

        public string LastID
        {
            set
            {
                LBLLastID.Text = value;
            }
        }

        public void SetEditMode(bool mode)
        {
            TXTBXFileID.ReadOnly = mode;
        }

        private void TXTBXFileID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public bool EditingMode { get; set; }
        private void BTNICEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTBXFileID.Text.Trim()))
                MessageBox.Show("برای اصلاح اطلاعات پرونده ابتدا شماره پرونده را وارد کرده سپس دکمه تغییر را بفشارید و در پایان برای ذخیره تغییرات، دکمه ذخیره را بزنید!!!");
            try
            {
                if (LoadUserProfileDefault(TXTBXFileID.Text))
                {
                    EditingMode = true;
                    TXTBXFileID.ReadOnly = true;
                }
                else
                    MessageBox.Show("شماره پرونده وارده صحیح نیست.");
            }
            catch
            {
            }
        }

        public bool LoadUserProfileDefault(string id)
        {
                    var result = Transaction.GetPatientList(FileID: id);
            if (result.Rows.Count < 1)
                return false;

            TXTBXFileID.Text = result.Rows[0]["IDSick"].ToString();
            if (result.Rows[0]["addr"] != System.DBNull.Value)
                TXTBXHomeAddress.Text = (string)result.Rows[0]["addr"];
            if (result.Rows[0]["Father"] != System.DBNull.Value)
                TXTPatientFatherName.Text = (string)result.Rows[0]["Father"];
            if (result.Rows[0]["FNameSick"] != System.DBNull.Value)
                TXTPatientFirstName.Text = (string)result.Rows[0]["FNameSick"];
            if (result.Rows[0]["LNameSick"] != System.DBNull.Value)
                TXTPatientLastName.Text = (string)result.Rows[0]["LNameSick"];
            if (result.Rows[0]["Tel"] != System.DBNull.Value)
                TXTTel.Text = (string)result.Rows[0]["Tel"];
            if (result.Rows[0]["TelQuick"] != System.DBNull.Value)
                TXTBXCellPhone.Text = (string)result.Rows[0]["TelQuick"];
            if (result.Rows[0]["melicode"] != System.DBNull.Value)
                TXTPatientNationalID.Text = (string)result.Rows[0]["melicode"];
            if (result.Rows[0]["Birthday"] != System.DBNull.Value)
                TXTPatientBirthDay.Text = (string)result.Rows[0]["Birthday"];
            if (result.Rows[0]["date_create"] != System.DBNull.Value)
                TXTBXRegisterDateTime.Text = (string)result.Rows[0]["date_create"];
            if (result.Rows[0]["date_create"] != System.DBNull.Value)
                TXTBXRegisterDateTime.Text = (string)result.Rows[0]["date_create"];
            if (result.Rows[0]["identifier"] != System.DBNull.Value)
                TXTBXRelation.Text = (string)result.Rows[0]["identifier"];
            if (result.Rows[0]["Birthday_city"] != System.DBNull.Value)
                TXTPatientBirthPlace.Text = (string)result.Rows[0]["Birthday_city"];
            if (result.Rows[0]["job_location"] != System.DBNull.Value)
                TXTOfficeAddress.Text = (string)result.Rows[0]["job_location"];
            if (result.Rows[0]["marrried_single"] != System.DBNull.Value)
            {
                RDBTNMaried.Checked = (byte)result.Rows[0]["marrried_single"] == 1;
                RDBTNSingle.Checked = !RDBTNMaried.Checked;
            }
            if (result.Rows[0]["comment"] != System.DBNull.Value)
            {
                int parsresult = -1;
                if (int.TryParse(result.Rows[0]["comment"].ToString(), out parsresult))
                {
                    this.PatientColorPanel.BackColor = cl[parsresult - 1];
                    CMBBXColor.SelectedIndex =  parsresult  - 1;
                }
            }

            if (result.Rows[0]["sex"] != System.DBNull.Value)
            {
                if ((string)result.Rows[0]["sex"] == "زن")
                    RDBTNFemale.Checked = true;
                else
                    RDBTNMale.Checked = true;
            }

            return true;
        }

        private void BTNICReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void BTNICCancel_Click(object sender, EventArgs e)
        {
            EditingMode = false;
            TXTBXFileID.ReadOnly = false;
            ResetForm();
        }

        private void BTNICPatientComback_Click(object sender, EventArgs e)
        {

        }

        private void BTNManageImageAndDocs_Click(object sender, EventArgs e)
        {
            FRMManageDocuments frmmd = new FRMManageDocuments();
            frmmd.MdiParent = this.MdiParent;
            frmmd.ShowDialog();
        }

        private void TXTBXFileID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
