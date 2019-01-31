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
    public partial class timeFilter : UserControl
    {
        public timeFilter()
        {
            InitializeComponent();
        }

        private void RDIBTNTime_CheckedChanged(object sender, EventArgs e)
        {
            GRPBXTime.Enabled = RDIBTNTime.Checked;
        }
    }
}
