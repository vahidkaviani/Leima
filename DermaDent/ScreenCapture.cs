using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent
{
    class ScreenCapture
    {
        public  Bitmap CaptureWindow()
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
            {
                Graphics g = Graphics.FromImage(bitmap);
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                //bitmap.Save("test.jpg", ImageFormat.Jpeg);
                return bitmap;
            }
        }
    }
}
