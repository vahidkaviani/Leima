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
    public partial class FRMDiagnosisTreatmentPlan : Form
    {
        public FRMDiagnosisTreatmentPlan()
        {
            InitializeComponent();
            initForm();
        }

        private void iconnedButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void initForm()
        {
            DTGRVPatientList.AutoGenerateColumns = false;
            dataGridView2.Columns[2].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView2.Columns[3].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView2.Columns[4].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView2.Columns[5].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            maskedTextBox2.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            maskedTextBox1.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            DTGRVPatientList.DataSource = Transaction.GetPatientList();
        }
    }
}
