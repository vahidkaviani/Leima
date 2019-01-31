using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace marlie.TumbnailDotnet
{
    public partial class ImageDialog : Form
    {
        List<string> otherFiles=new List<string>();
        int filenamePointer;
        string path;
        public ImageDialog()
        {
            InitializeComponent();
            
        }

        public void SetImage(string filename)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(SetImageIntern));
            thread.IsBackground = true;
            thread.Start(filename);
            ScanNeighbours(filename);
        }

        void ScanNeighbours(string filename)
        {
            path = Path.GetDirectoryName(filename);
            string name = Path.GetFileName(filename);
            int temp=0;
            otherFiles.Clear();
            foreach (string S in Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly))
            {
                string s = S.ToLower();
                if (s.EndsWith(".gif")  ||
                    s.EndsWith(".jpg")  ||
                    s.EndsWith(".bmp")  ||
                    s.EndsWith(".jpeg") ||
                    s.EndsWith(".png")  ||
                    s.EndsWith(".tiff"))
                {
                    otherFiles.Add(s);
                    temp++;
                    if (string.Equals(name, s, StringComparison.OrdinalIgnoreCase)) filenamePointer = temp;
                }
            }
        }
        private void SetImageIntern(object filename)
        {
            this.imageViewerFull.Image = Image.FromFile((string)filename);
            this.imageViewerFull.Invalidate();
        }

        private void ImageDialog_Resize(object sender, EventArgs e)
        {
            this.imageViewerFull.Invalidate();
        }

        private void BTNNext_Click(object sender, EventArgs e)
        {
            next();
        }
        private void next()
        {
            filenamePointer++;
            filenamePointer = filenamePointer % otherFiles.Count;
            Thread thread = new Thread(new ParameterizedThreadStart(SetImageIntern));
            thread.IsBackground = true;
            thread.Start(otherFiles[filenamePointer]);
        }
        private void BTNPrevious_Click(object sender, EventArgs e)
        {
            Previous();
        }
        private void Previous()
        {
            filenamePointer--;
            if (filenamePointer < 0)
                filenamePointer = otherFiles.Count - 1;
            filenamePointer = filenamePointer % otherFiles.Count;
            Thread thread = new Thread(new ParameterizedThreadStart(SetImageIntern));
            thread.IsBackground = true;
            thread.Start(otherFiles[filenamePointer]);
        }
        private void ManagePics(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='1')
            Previous();
            
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Previous();
                    break;
                case Keys.Right:
                    next();
                    break;
                default:
                    break;
            }
        }

            protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                    Previous();
                    break;
                case Keys.Up:
                case Keys.Down:
                    return true;
                case Keys.Shift | Keys.Right:
                case Keys.Shift | Keys.Left:
                case Keys.Shift | Keys.Up:
                case Keys.Shift | Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }

        private void imageViewerFull_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Previous();
                    break;
                case Keys.Right:
                    next();
                    break;
                default:
                    break;
            }
        }

        private void imageViewerFull_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Previous();
                    break;
                case Keys.Right:
                    next();
                    break;
                default:
                    break;
            }
        }
    }
}