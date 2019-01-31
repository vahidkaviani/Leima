using System.Collections.Generic;
using System.Drawing;
namespace DermaDent.Bot
{
    
    class FormatPrinterChargeReport
    {
        /***************************************************/
        public static Bitmap BaseImage;
            Graphics g = null;
        public Bitmap bmp;//= new Bitmap(210 * 4, 297 * 4);
            public string drName { get; set; }
            public string fromDate { get; set; }
            public string ToDate { get; set; }
            public string PatientName { get; set; }
            public string PatientID { get; set; }
            public FormatPrinterChargeReport()
            {
            if (BaseImage == null)
                BaseImage = (Bitmap)Bitmap.FromFile("InvoiceTemplateBot1.png");
            bmp = new Bitmap(BaseImage.Width, BaseImage.Height);
                Redraw();
            }
        double scaleFactor = 2.0238095238095238095238095238095;
        int GetScaleFactor(int val)
        {
            return (int)(val * scaleFactor);
        }
            public void Redraw()
            {
                g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, BaseImage.Width
                , BaseImage.Height);
            g.DrawImage(BaseImage, 0, 0);
                

                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                Pen p = new Pen(Color.Black, 1);
                //Bitmap Logo = (Bitmap)Image.FromFile(@"Logo.png");
                //g.DrawImage(Logo, 0, 0, GetScaleFactor(120), GetScaleFactor(100));
                int buttomOffset = 10;
                //g.DrawLine(p, 20, 100, 20, bmp.Height - buttomOffset);
                //g.DrawLine(p, bmp.Width - 20, 100, bmp.Width - 20, bmp.Height - buttomOffset);

                //g.DrawLine(p, 160, 100, 160, bmp.Height - buttomOffset - 40);

                //g.DrawLine(p, 300, 100, 300, bmp.Height - buttomOffset - 40);

                //g.DrawLine(p, 620, 100, 620, bmp.Height - buttomOffset - 40);

                //g.DrawLine(p, 780, 100, 780, bmp.Height - buttomOffset - 40);

                string s = string.Format("نام پزشک: {0}", drName);
                g.DrawString(s, new Font("B Nazanin", 27,FontStyle.Bold), Brushes.Black, 1290, 30);

                s = string.Format(" از تاریخ: {0}", fromDate);
                g.DrawString(s, new Font("B Nazanin", 20), Brushes.Black, 100, 15);

                s = string.Format(" تا تاریخ: {0}", ToDate);
                g.DrawString(s, new Font("B Nazanin", 20), Brushes.Black,100, 50);

                s = string.Format("کلینیک دندانپزشکی آرن");
                g.DrawString(s, new Font("B Titr", 30, FontStyle.Bold), Brushes.Black, 650, 20);


                int lines = 28;
                //for (int i = 0; i < lines; i++)
                //{

                //    g.DrawLine(p, 20, i * 40 + 100, bmp.Width - 20, i * 40 + 100);
                //    if (i + 3 < lines && i != 0)
                //        g.DrawString(i.ToString(), new Font("B Nazanin", 16), Brushes.Black, 790, i * 40 + 110);
                //}

               // g.DrawString("نام بیمار", new Font("B Nazanin", 16, FontStyle.Bold), Brushes.Black, GetScaleFactor(680), GetScaleFactor(100));
               // g.DrawString("نام خدمت", new Font("B Nazanin", 16, FontStyle.Bold), Brushes.Black, GetScaleFactor(430), GetScaleFactor(100));
               // g.DrawString("هزینه خدمت", new Font("B Nazanin", 16, FontStyle.Bold), Brushes.Black, GetScaleFactor(180), GetScaleFactor(100));
               // g.DrawString("سهم پزشک", new Font("B Nazanin", 16, FontStyle.Bold), Brushes.Black, GetScaleFactor(40), GetScaleFactor(100));



            }
            public void DrawTableContent(List<DR_Charge> d)
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                for (int i = 0; i < 25 && i < d.Count - 1; i++)
                {
                    g.DrawString(d[i].patientname, new Font("B Nazanin", 28, FontStyle.Regular), Brushes.Black, GetScaleFactor(710), i * 73 + 200, stringFormat);

                    g.DrawString(d[i].servicename, new Font("B Nazanin", 24, FontStyle.Bold), Brushes.Black, 1050, i * 74 + 200, stringFormat);

                    g.DrawString(string.Format("{0:#,##0}", d[i].ServicePrice), new Font("B Nazanin", 24, FontStyle.Bold), Brushes.Black, 295, i * 73 + 200, stringFormat);

                    g.DrawString(string.Format("{0:#,##0}", d[i].DrPerCase), new Font("B Nazanin", 26, FontStyle.Bold), Brushes.Black, 120, i * 73 + 200, stringFormat);
                    g.DrawString(string.Format("{0:#,##0}", d[i].VisiteDateTime), new Font("B Nazanin", 24, FontStyle.Bold), Brushes.Black, 675, i * 73 + 200, stringFormat);
                ///////////////// tooth no /////////
                g.DrawString(string.Format("{0:#,##0}", d[i].t3), new Font("B Nazanin", 22, FontStyle.Bold), Brushes.Black, 420, i * 73 + 216, stringFormat); // paein chap
                g.DrawString(string.Format("{0:#,##0}", d[i].t2), new Font("B Nazanin", 22, FontStyle.Bold), Brushes.Black, 520, i * 73 + 180, stringFormat);   // bala rast 
                g.DrawString(string.Format("{0:#,##0}", d[i].t1), new Font("B Nazanin", 22, FontStyle.Bold), Brushes.Black, 420, i * 73 + 180, stringFormat); // bala chap
                g.DrawString(string.Format("{0:#,##0}", d[i].t4), new Font("B Nazanin", 22, FontStyle.Bold), Brushes.Black, 520, i * 73 + 216, stringFormat); // paein rast
                //////////////////////////
            }

               //g.DrawString(d[d.Count - 1].patientname, new Font("B Nazanin", 24, FontStyle.Regular), Brushes.Black, 710, 25 * 73 + 200, stringFormat);

                g.DrawString(d[d.Count - 1].servicename, new Font("B Nazanin", 24, FontStyle.Bold), Brushes.Black, 680, 25 * 73 + 200, stringFormat);

              g.DrawString(string.Format("{0:#,##0}", d[d.Count - 1].ServicePrice), new Font("B Nazanin", 24, FontStyle.Bold), Brushes.Black, 300, 25 * 73 + 200, stringFormat);

                g.DrawString(string.Format("{0:#,##0}", d[d.Count - 1].DrPerCase), new Font("B Nazanin", 24, FontStyle.Bold), Brushes.Black, 110, 25 * 73 + 200, stringFormat);
            }
        }
    

    /***************************************************/
}
