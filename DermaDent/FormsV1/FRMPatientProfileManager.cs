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
    public partial class FRMPatientProfileManager : Form
    {
        public FRMPatientProfileManager(string LastId=null)
        {
            InitializeComponent();
            if (LastId != null)
                patientRegisterControl1.LastID = LastId;
        }

        private void BTNNewPatient_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (patientRegisterControl1.Register())
            {
                MessageBox.Show("پرونده جدید با موفقیت ایجاد شد");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
