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
    public partial class FRMEditUserProfile : Form
    {
        public FRMEditUserProfile()
        {
            InitializeComponent();
        }
        public FRMEditUserProfile(string LastID)
        {
            InitializeComponent();
            patientRegisterControl1.LastID = LastID;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                patientRegisterControl1.LoadUserProfileDefault(BTNLoadInfo.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = CHKBOXEditMode.Checked;
            patientRegisterControl1.SetEditMode(CHKBOXEditMode.Checked);
            if (CHKBOXEditMode.Checked)
                BTNSaveChanges.Text = "ذخیره تغییرات";
            else
                BTNSaveChanges.Text = "ثبت پرونده";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNSaveChanges_Click(object sender, EventArgs e)
        {
            if (CHKBOXEditMode.Checked)
            {
                if (patientRegisterControl1.UpdateUserProfile())
                    label3.Text = "تغییرات مورد نظر شما اعمال شد!";
                else
                    label3.Text = "خطا!!!";
            }
            else
            {
                if(patientRegisterControl1.Register())
                    label3.Text = "با موفقیت ثبت شد!";
                else
                    label3.Text = "خطا!!!";
            }
            
        }
    }
}
