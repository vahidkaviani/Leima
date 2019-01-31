using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent
{
    public partial class TeethQuadrant : UserControl
    {
        public TeethQuadrant()
        {
            InitializeComponent();
            RegisterCheckBoxEventHandler();
        }


        void RegisterCheckBoxEventHandler()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)item).CheckStateChanged += new EventHandler(ToothSelected);
                }
            }
        }
        public TeethQuadrant(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            RegisterCheckBoxEventHandler();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            CreateGraphics().DrawLine(System.Drawing.Pens.Black, this.Width / 2, 30, this.Width / 2, this.Height - 30);

            CreateGraphics().DrawLine(System.Drawing.Pens.Black, 10, this.Height / 2 + 5, this.Width - 10, this.Height / 2 + 5);
        }

        public void GetServiceAreaCode()
        {

        }

        private void ToothSelected(object sender, EventArgs e)
        {
            // int selectedTooth=int.Parse(((CheckBox)sender).Name.Substring(2));
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    if (((CheckBox)item).Name != ((CheckBox)sender).Name)
                    {
                      //  ((CheckBox)item).Checked = false;
                    }
                }
            }
        }

        public void Clear()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                          ((CheckBox)item).Checked = false;
                }
            }
        }

        public List<string> GetServiceArea()
        {
            List<string> retVal=new List<string>();
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    CheckBox c = (CheckBox)item;
                    if (c.Checked)
                    {
                        retVal.Add(c.Name);
                    }
                }
            }
            return retVal;
        }
    }
}
