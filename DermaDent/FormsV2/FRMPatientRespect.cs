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
    public partial class FRMPatientRespect : Form
    {
        public string PatientID { get; set; }
        public FRMPatientRespect(string UserName, string PatientID = null)
        {
            InitializeComponent();
            TXTBXRespectTime.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            textBox2.Text = DateTime.Now.ToString("HH:mm");
            this.PatientID = PatientID;

            if (!string.IsNullOrEmpty(PatientID))
                LoadPatientInfo();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            // switch case is the easy way, a hash or map would be better, 
            // but more work to get set up.
            switch (keyData)
            {
                case Keys.F3:
                    FRMSearchPatient frmsearch = new FRMSearchPatient();
                    frmsearch.ShowDialog();
                    this.PatientID=frmsearch._PatientID;
                    LoadPatientInfo();
                    bHandled = true;
                    break;
            }
            return bHandled;
        }

        void LoadPatientInfo()
        {
            var v = Transaction.GetPatientList(FileID: PatientID);
            TXTBXFileID.Text = PatientID;
            TXTBXFirstName.Text = (string)v.Rows[0]["FNameSick"];
            TXTBXLastName.Text = (string)v.Rows[0]["LNameSick"];
        }
        private void BTNICExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
