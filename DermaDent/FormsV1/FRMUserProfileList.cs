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
    public partial class FRMUserProfileList : Form
    {
        public FRMUserProfileList()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(ManagePatientList);
            var v=Transaction.GetPatientList();
            this.dataGridView1.DataSource = v;
        }

        void ManagePatientList(object obj, DataGridViewCellFormattingEventArgs e)
        {
            //dataGridView1.Rows[e.RowIndex].Cells[0].
            try
            {
                if (e.ColumnIndex == 0)
                    e.CellStyle.BackColor = FRMPatientInfo.cl[int.Parse(dataGridView1.Rows[e.RowIndex].Cells["comment"].Value.ToString()) - 1];
            }
            catch { }
            //foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            //{            //Here 2 cell is target value and 1 cell is Volume
            //    if (Convert.ToInt32(Myrow.Cells[2].Value) < Convert.ToInt32(Myrow.Cells[1].Value))// Or your condition 
            //    {
            //        Myrow.DefaultCellStyle.BackColor = Color.Red;
            //    }
            //    else
            //    {
            //        Myrow.DefaultCellStyle.BackColor = Color.Green;
            //    }
            //}
        }
        private void FilterData(object sender, KeyPressEventArgs e)
        {

        }

        public void ExportData(DataGridView dgv)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Comma separated files|*.csv";
            if (SFD.ShowDialog() != DialogResult.OK)
                return;
            var v = System.IO.File.CreateText(SFD.FileName);

            var sb = new StringBuilder();

            var headers = dgv.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            v.Write(sb);
            v.Flush();
            v.Close();
        }

        private void ذخیرهدرفایلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportData(dataGridView1);
        }
    }
}
