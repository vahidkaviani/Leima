using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent
{
    public partial class PatientOveralDetail : UserControl
    {
        public PatientOveralDetail(string patientID)
        {
            InitializeComponent();
        }

        public void UpdatePatientID(string PatientID)
        {
            Transaction.GetPatientList(FileID: PatientID);
        }
    }
}
