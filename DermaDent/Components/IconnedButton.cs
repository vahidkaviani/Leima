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
    public partial class IconnedButton : Button
    {
        public IconnedButton()
        {
            InitializeComponent();
            this.Height = 32;
            this.ImageAlign = ContentAlignment.MiddleRight;
            this.TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
