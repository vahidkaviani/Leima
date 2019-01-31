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
    public partial class FRMSearchTimeAllocated : Form
    {
        public FRMSearchTimeAllocated()
        {
            InitializeComponent();
            DGVPatientVisitingTimes.AutoGenerateColumns = false;
            TXTBXDate.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            UpdatePatientTable();
        }

        private void BTNICExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        void UpdatePatientTable()
        {
            DateTime from = DateTime.Now;
            from = from.AddHours(-DateTime.Now.Hour);
            DateTime to = DateTime.Now;
            to.AddHours(24 - DateTime.Now.Hour);
            if(CHKBX.Checked)
                DGVPatientVisitingTimes.DataSource = Transaction.GetReservedTime(PersianDateTime.GetPersianDate(DateTime.Now),PersianDateTime.GetPersianDate(DateTime.Now), PatientID: TXTBXID.Text, PFirstName: TXTBXFirstName.Text, PLastName: TXTBXLastName.Text);
            else
                DGVPatientVisitingTimes.DataSource = Transaction.GetReservedTime(PersianDateTime.GetPersianDate(DateTime.Now), PersianDateTime.GetPersianDate(DateTime.Now.AddYears(3)), PatientID: TXTBXID.Text, PFirstName: TXTBXFirstName.Text, PLastName: TXTBXLastName.Text);
        }

        private void TXTBXID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
                UpdatePatientTable();
        }

        private void CHKBX_CheckedChanged(object sender, EventArgs e)
        {
            TXTBXDate.Enabled = true;
            UpdatePatientTable();
        }
    }
}
