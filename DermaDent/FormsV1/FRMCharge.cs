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
    public partial class FRMCharge : Form
    {
        public FRMCharge()
        {
            InitializeComponent();
        }

        private void TXTBXTTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
            TXTBXTTotalPrice.Text = FormatText(TXTBXTTotalPrice.Text, e.KeyChar.ToString());
            e.Handled = true;
        }

        public string FormatText(string current,string input)
        {
            int result;
            bool right;
            right=int.TryParse(current, out result);
            if (!right)
            {
                right = int.TryParse(input, out result);
                if (!right)
                    return "0";
                return input.ToString();
            }
            right = int.TryParse(input, out result);

            if (!right)
                return int.Parse(current).ToString();

            return int.Parse(current + input).ToString();
        }

        private void TXTBXTTotalPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int res = int.Parse(TXTBXTTotalPrice.Text) / 10;
                LBLPriceText.Text = new number2Text.PNumberTString().num2str(res.ToString()) + " تومان";
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                pictureBox1.Load(openFileDialog1.FileName);
            }
            catch
            {
            }
        }
    }
}
