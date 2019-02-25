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
    public partial class FRMAllAllocatedTime : Form
    {
        public FRMAllAllocatedTime()
        {
            InitializeComponent();
            dataGridView1.Columns[7].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView1.Columns[8].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView1.Columns[9].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            dataGridView1.Columns[10].HeaderCell.Style.Font = new Font("Wingdings 3", 10, FontStyle.Regular);
            persianDateTimeBox1.Text = "1390/01/01";
            persianDateTimeBox2.Text = PersianDateTime.GetPersianDate(DateTime.Now.AddYears(5));
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (e.ColumnIndex == dgv.Columns["Status"].Index)
                {
                    if (e.Value == null)
                        return;
                    short Status = (short)e.Value;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = FRMReserverdTime.statusColor[Status];
                    e.Value = FRMReserverdTime.StatusDetail[(short)e.Value];
                    if (Status == 5)
                        dgv.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                }
            }
            catch { }
        }

        private void TXTBXID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                updateVisitTime();
        }

        private void updateVisitTime()
        {
            dataGridView1.DataSource = Transaction.GetReservedTime(persianDateTimeBox1.Text, persianDateTimeBox2.Text, PatientID: TXTBXID.Text,OnlyAllocated:true);
        }

        private void BTNICClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconnedButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("پرینتر یافت نشد!");
        }

        private void iconnedButton4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("شما دسترسی مدیریتی ندارید لطفا با مدیر مجموعه تماس بگیرید !");
            ExportData(dataGridView1);
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
    }
}
