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
    public partial class CashPayment : UserControl
    {
        public CashPayment()
        {
            InitializeComponent();
        }

        private void TextBoxCostKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
                {
                    e.Handled = true;
                }


            }
            catch (Exception ex)
            {
                //ExceptionkeeperBll.LogFileWrite(ex);
            }
        }

        private void TextBoxCostTextChanged(object sender, EventArgs e)
        {
            try
            {
                string value = TextBoxCost.Text.Replace(",", "");
                ulong ul;
                if (ulong.TryParse(value, out ul))
                {
                    TextBoxCost.TextChanged -= TextBoxCostTextChanged;
                    TextBoxCost.Text = string.Format("{0:#,#}", ul);
                    TextBoxCost.SelectionStart = TextBoxCost.Text.Length;
                    TextBoxCost.TextChanged += TextBoxCostTextChanged;
                }
            }
            catch (Exception ex)
            {
               // ExceptionkeeperBll.LogFileWrite(ex);
            }
        }
    }
}
