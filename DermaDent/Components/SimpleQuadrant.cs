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
    public partial class SimpleQuadrant : UserControl
    {
        public SimpleQuadrant()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(Pens.Black, this.Width / 2-1, 0, this.Width / 2-1, this.Height);

            e.Graphics.DrawLine(Pens.Black, 0, this.Height/2-1, this.Width , this.Height/2-1);

        }

        public string ToothId
        {
            get
            {           //  Top left            top right           bottom left          bottom right
                return textBox1.Text + "." + textBox3.Text + "." + textBox2.Text + "." + textBox4.Text;
            }
        }
        public string ToothMap {
            get
            {
                string map = "";
                if (!string.IsNullOrEmpty(textBox1.Text))
                    map += textBox1.Text + "بالا چپ"+"\r\n";
                if (!string.IsNullOrEmpty(textBox3.Text))
                    map += textBox3.Text + "بالا راست" + "\r\n";
                if (!string.IsNullOrEmpty(textBox2.Text))
                    map += textBox2.Text + "پایین چپ" + "\r\n";
                if (!string.IsNullOrEmpty(textBox4.Text))
                    map += textBox4.Text + "پایین راست" + "\r\n";
                return map;
            }
        }

        public static string GetToothMapFrom(string s)
        {
            string[] temp = s.Trim().Split('.');
            string map = "";

            if (!string.IsNullOrEmpty(temp[0]))
                map += temp[0] + "بالا چپ" + " ";

            if (!string.IsNullOrEmpty(temp[1]))
                map += temp[1] + "بالا راست" + " ";

            if (!string.IsNullOrEmpty(temp[2]))
                map += temp[2] + "پایین چپ" + " ";
            if (!string.IsNullOrEmpty(temp[3]))
                map += temp[3] + "پایین راست" + " ";
            return map;
        }
        private void ToothNoEntered(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = t.Text.ToUpper();
            //string name = t.Name;
            //if (string.IsNullOrEmpty(t.Text))
            //    return;

            //if (name != textBox1.Name)
            //    textBox1.Text = "";

            //if (name != textBox2.Name)
            //    textBox2.Text = "";

            //if (name != textBox3.Name)
            //    textBox3.Text = "";

            //if (name != textBox4.Name)
            //    textBox4.Text = "";
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
