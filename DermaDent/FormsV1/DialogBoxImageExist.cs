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
    public partial class DialogBoxImageExist : Form
    {
        string source;
        string dest;
        public DialogBoxImageExist(string FileA,string FileB,string FileName)
        {
            InitializeComponent();
            source = FileA;
            dest = FileB;
            imageViewer2.LoadImage(FileA, imageViewer1.Width, imageViewer1.Height);
            imageViewer1.LoadImage(FileB, imageViewer1.Width, imageViewer1.Height);
            label1.Text = string.Format("تصویری با نام \"{0}\" از قبل در پرونده بیمار موجود می باشد",FileName);
        }

        private void BTNReplace_Click(object sender, EventArgs e)
        {
            System.IO.File.Copy(source, dest, true);
        }

        private void BTNSkip_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNKeepBoth_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileNameWithoutExtension(source);
            string fileExtension = new System.IO.FileInfo(source).Extension;
            string path = System.IO.Path.GetDirectoryName(dest);
            fileName += DateTime.Now.ToString("yyyyMMddhhmmss");
            dest = System.IO.Path.Combine(path, fileName);
            System.IO.File.Copy(source, dest, true);
            Close();
        }
    }
}
