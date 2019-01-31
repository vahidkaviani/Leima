using DermaDent.Properties;
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
    public partial class FRMAuthentication : Form
    {
        
        public bool AuthenticationResult { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string PSWD { get; set; }
        public SoftwareUserInfo SU_{ get; set; }
        public FRMAuthentication()
        {
            InitializeComponent();
#if DEBUG
            TXTBXUserName.Text = "1";
            TXTBXPassword.Text= "5566";
            
#endif
        }
        private void Authenticate()
        {
            var v = Transaction.AuthenticateUser(TXTBXUserName.Text.Trim(), TXTBXPassword.Text.Trim());

            if (v.id==-1)
            {
                    TXTBXPassword.Text = "";
            }
            else
            {
                UserName = v.name;
                UserID = v.id;
                PSWD = v.password;
                SU_ = v;
                pictureBox1.Image = Resources.ezgif_4_8d018b9503;
                int i = 0;
                while (i < 200)
                {
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(5);
                    i++;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void BTNLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private void TXTBXPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n'|| e.KeyChar == '\r')
                Authenticate();
        }

        private void TXTBXUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
                SendKeys.Send("{TAB}");
        }
    }
}
