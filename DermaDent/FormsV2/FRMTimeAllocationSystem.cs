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
    public partial class FRMTimeAllocationSystem : Form
    {
        public FRMTimeAllocationSystem()
        {
            InitializeComponent();
            dataGridView2.Columns[4].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView2.Columns[5].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView2.Columns[6].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView2.Columns[7].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
        }

        private void BTNICClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
