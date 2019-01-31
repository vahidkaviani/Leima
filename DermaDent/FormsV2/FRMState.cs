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
    public partial class FRMState : Form
    {
        public FRMState()
        {
            InitializeComponent();
        }

        private void BTNICReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
