using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace DermaDent
{
    public partial class PatientRegisterControl : UserControl
    {
        Color[] cl = new Color[] { Color.Red, Color.SpringGreen, Color.CornflowerBlue, Color.Gold, Color.DarkViolet };
        public PatientRegisterControl()
        {
            InitializeComponent();
            TXTBXRegisterDateTime.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            CMBBXColor.DrawItem += new DrawItemEventHandler(CMBBXColor_DrawItem);

            for (int i = 0; i < 5; i++)
                CMBBXColor.Items.Add((i + 1).ToString());
        }
        public PatientRegisterControl(string lasid = null)
        {
            InitializeComponent();

            TXTBXRegisterDateTime.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            CMBBXColor.DrawItem += new DrawItemEventHandler(CMBBXColor_DrawItem);

            for (int i = 0; i < 5; i++)
                CMBBXColor.Items.Add((i + 1).ToString());

            if (lasid != null)
                LastID = lasid;
        }
 
        private void CMBBXColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 12, FontStyle.Regular);
                Color c = cl[int.Parse(n)-1];
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 20, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        public  bool Register ()
        {
            try
            {
                int maried = 0;
                string gender = "زن";
                if (RBMale.Checked)
                    gender = "مرد";
                Transaction.NewPatient(TXTBxFirstName.Text,
                    TXTBXLastName.Text,
                   TXTBXFileID.Text,
                   gender,
                   TXTBXPersianBirthday.Text,
                   TXTBXAddress.Text,
                   TXTBXMobile.Text,
                   TXTBXHomeTel.Text,
                   TXTBXNationID.Text,
                   TXTBXFatherName.Text,
                   TXTBXRegisterDateTime.Text,
                   CMBBXReagent.Text
                   );
                TXTBxFirstName.Text = string.Empty;
                TXTBXLastName.Text = string.Empty;
                TXTBXHomeTel.Text = string.Empty;
                TXTBXNationID.Text = string.Empty;
                TXTBXMobile.Text = string.Empty;
                TXTBXFatherName.Text = string.Empty;
                TXTBXAddress.Text = string.Empty;
                TXTBXFileID.Text = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
        public bool UpdateUserProfile()
        {
            try
            {
                string gender = "زن";
                if (RBMale.Checked)
                    gender = "مرد";
                Transaction.UpdatePatient(TXTBxFirstName.Text,
                    TXTBXLastName.Text,
                   TXTBXFileID.Text,
                   gender,
                   TXTBXPersianBirthday.Text,
                   TXTBXAddress.Text,
                   TXTBXMobile.Text,
                   TXTBXHomeTel.Text,
                   TXTBXNationID.Text,
                   TXTBXFatherName.Text,
                   TXTBXRegisterDateTime.Text,
                   CMBBXReagent.Text
                   );
                TXTBxFirstName.Text = string.Empty;
                TXTBXLastName.Text = string.Empty;
                TXTBXHomeTel.Text = string.Empty;
                TXTBXNationID.Text = string.Empty;
                TXTBXMobile.Text = string.Empty;
                TXTBXFatherName.Text = string.Empty;
                TXTBXAddress.Text = string.Empty;
                TXTBXFileID.Text = string.Empty;
                TXTBXRegisterDateTime.Text = string.Empty;
                CMBBXReagent.Text = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
        private void CMBBXColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string color = this.CMBBXColor.SelectedItem.ToString();
            this.panel1.BackColor = cl[int.Parse(color)-1];
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

        public bool LoadUserProfileDefault(string id)
        {
            var result = Transaction.GetPatientList(FileID: id);
            if (result.Rows.Count < 1)
                return false;
            
            TXTBXFileID.Text= result.Rows[0]["IDSick"].ToString();
            if(result.Rows[0]["addr"]!=System.DBNull.Value)
                TXTBXAddress.Text = (string)result.Rows[0]["addr"];
            if (result.Rows[0]["Father"] != System.DBNull.Value)
                TXTBXFatherName.Text= (string)result.Rows[0]["Father"];
            if (result.Rows[0]["FNameSick"] != System.DBNull.Value)
                TXTBxFirstName.Text = (string)result.Rows[0]["FNameSick"];
            if (result.Rows[0]["LNameSick"] != System.DBNull.Value)
                TXTBXLastName.Text = (string)result.Rows[0]["LNameSick"];
            if (result.Rows[0]["Tel"] != System.DBNull.Value)
                TXTBXHomeTel.Text = (string)result.Rows[0]["Tel"];
            if (result.Rows[0]["TelQuick"] != System.DBNull.Value)
                TXTBXMobile.Text = (string)result.Rows[0]["TelQuick"];
            if (result.Rows[0]["melicode"] != System.DBNull.Value)
                TXTBXNationID.Text = (string)result.Rows[0]["melicode"];
            if (result.Rows[0]["Birthday"] != System.DBNull.Value)
                TXTBXPersianBirthday.Text = (string)result.Rows[0]["Birthday"];
            if (result.Rows[0]["date_create"] != System.DBNull.Value)
                TXTBXRegisterDateTime.Text = (string)result.Rows[0]["date_create"];
            if (result.Rows[0]["identifier"] != System.DBNull.Value)
                CMBBXReagent.Text = (string)result.Rows[0]["identifier"];
            if (result.Rows[0]["sex"] != System.DBNull.Value)
            {
                if ((string)result.Rows[0]["sex"] == "زن")
                    RBFemale.Checked = true;
                else
                    RBMale.Checked = true;
            }

            return true;
        }
    }
}
