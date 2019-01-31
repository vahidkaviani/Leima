using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaDent.Bot
{
    public struct DR_Charge
    {
        public string patientname;
        public string servicename;
        public int ServicePrice;
        public int DrPerCase;
        public string drName;
        public string VisiteDateTime;
        public string t1;
        public string t2;
        public string t3;
        public string t4;
    };
    public class FormatPrinter
    {

        Graphics g = null;
        public Bitmap bmp = new Bitmap(210 * 4, 297 * 4);
        public string drName { get; set; }
        public string fromDate { get; set; }
        public string ToDate { get; set; }
        public string PatientName { get; set; }
        public string PatientID { get; set; }
        public FormatPrinter()
        {
            
            Redraw();
        }
        public void Redraw()
        {

            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, bmp.Width
                , bmp.Height);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            Pen p = new Pen(Color.Black, 1);
            Bitmap Logo = (Bitmap)Image.FromFile(@"Logo.png");
            g.DrawImage(Logo, 0, 0, 120, 100);
            int buttomOffset = 10;
            g.DrawLine(p, 20, 100, 20, bmp.Height - buttomOffset);
            g.DrawLine(p, bmp.Width - 20, 100, bmp.Width - 20, bmp.Height - buttomOffset);

            g.DrawLine(p, 160, 100, 160, bmp.Height - buttomOffset - 40);

            g.DrawLine(p, 300, 100, 300, bmp.Height - buttomOffset - 40);

            g.DrawLine(p, 620, 100, 620, bmp.Height - buttomOffset - 40);

            g.DrawLine(p, 780, 100, 780, bmp.Height - buttomOffset - 40);

            string s = string.Format("نام پزشک: {0}", drName);
            g.DrawString(s, new Font("B Nazanin", 16), Brushes.Black, 600, 10);

            s = string.Format(" از تاریخ: {0}", fromDate);
            g.DrawString(s, new Font("B Nazanin", 16), Brushes.Black, 600, 35);

            s = string.Format(" تا تاریخ: {0}", ToDate);
            g.DrawString(s, new Font("B Nazanin", 16), Brushes.Black, 600, 60);

            s = string.Format("کلینیک دندانپزشکی آرن");
            g.DrawString(s, new Font("B Titr", 19, FontStyle.Bold), Brushes.Black, 300, 20);


            int lines = 28;
            for (int i = 0; i < lines; i++)
            {

                g.DrawLine(p, 20, i * 40 + 100, bmp.Width - 20, i * 40 + 100);
                if (i + 3 < lines && i != 0)
                    g.DrawString(i.ToString(), new Font("B Nazanin", 16), Brushes.Black, 790, i * 40 + 110);
            }

            g.DrawString("نام بیمار", new Font("B Nazanin", 16, FontStyle.Bold), Brushes.Black, 680, 100);
            g.DrawString("نام خدمت", new Font("B Nazanin", 16, FontStyle.Bold), Brushes.Black, 430, 100);
            g.DrawString("هزینه خدمت", new Font("B Nazanin", 16, FontStyle.Bold), Brushes.Black, 180, 100);
            g.DrawString("سهم پزشک", new Font("B Nazanin", 16, FontStyle.Bold), Brushes.Black, 40, 100);



        }
        public void DrawTableContent(List<DR_Charge> d)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            for (int i = 0; i < 25 && i < d.Count-1; i++)
            {
                g.DrawString(d[i].patientname, new Font("B Nazanin", 14, FontStyle.Regular), Brushes.Black, 710, i * 40 + 160, stringFormat);

                g.DrawString(d[i].servicename, new Font("B Nazanin", 12, FontStyle.Bold), Brushes.Black, 475, i * 40 + 160, stringFormat);

                g.DrawString(string.Format("{0:#,##0}", d[i].ServicePrice), new Font("B Nazanin", 14, FontStyle.Bold), Brushes.Black, 230, i * 40 + 160, stringFormat);

                g.DrawString(string.Format("{0:#,##0}", d[i].DrPerCase), new Font("B Nazanin", 14, FontStyle.Bold), Brushes.Black, 90, i * 40 + 160, stringFormat);
            }
             
            g.DrawString(d[d.Count-1].patientname, new Font("B Nazanin", 14, FontStyle.Regular), Brushes.Black, 710,25 * 40 + 160, stringFormat);

            g.DrawString(d[d.Count-1].servicename, new Font("B Nazanin", 14, FontStyle.Bold), Brushes.Black, 480, 25 * 40 + 160, stringFormat);

            g.DrawString(string.Format("{0:#,##0}", d[d.Count-1].ServicePrice), new Font("B Nazanin", 14, FontStyle.Bold), Brushes.Black, 230, 25 * 40 + 160, stringFormat);

            g.DrawString(string.Format("{0:#,##0}", d[d.Count-1].DrPerCase), new Font("B Nazanin", 14, FontStyle.Bold), Brushes.Black, 90, 25 * 40 + 160, stringFormat);
        }
    }
}
