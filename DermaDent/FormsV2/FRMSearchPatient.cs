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
    public partial class FRMSearchPatient : Form
    {
        public string _PatientID { get; set; }
        public FRMSearchPatient()
        {
            InitializeComponent();
            _PatientID = "-1";
            DGVPatientList.AutoGenerateColumns = false;
            UpdateTable();
        }

        void UpdateTable()
        {
            DGVPatientList.DataSource = Transaction.GetPatientList(FirstName:TXTBXFirstName.Text,LastName:TXTBXLastName.Text,FileID:TXTBXFileID.Text,meliCode:TXTBXNationID.Text);
        }

        private void UpdatePatientList(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
                UpdateTable();
        }

        private void BTNCancell_Click(object sender, EventArgs e)
        {
            _PatientID = "-1";
            this.Close();
        }

        private void SelectPatient(object sender, EventArgs e)
        {
            try
            {
                _PatientID = DGVPatientList.Rows[DGVPatientList.CurrentCell.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
            catch
            { }
        }

        private void BTNSelect_Click(object sender, EventArgs e)
        {
            try
            {
                _PatientID = DGVPatientList.Rows[DGVPatientList.CurrentCell.RowIndex].Cells[0].Value.ToString();
                this.Close();
            }
            catch
            { }
        }
        private void TXTBXLastName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTBXLastName.Text))
                UpdateTable();
            if (string.IsNullOrEmpty(TXTBXLastName.Text))
                return;
            if (TXTBXLastName.Text.Trim().Length > 2)
                UpdateTable();
            
        }
    }
}
