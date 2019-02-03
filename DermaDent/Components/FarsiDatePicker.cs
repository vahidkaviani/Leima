using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace DermaDent
{
    
    public partial class FarsiDatePicker : UserControl
    {
        StringFormat format;
        public Color CBackColor { get; set; }
        public Color CTodayRectColor { get; set; }
        public Color CWorkingDayColor { get; set; }
        public Color CNoneWorkingDayColor { get; set; }
        public Color CTodayFullDateColor { get; set; }
        public Color CTodayFullDate { get; set; }
        public int _PresentingYear { get; set; }
        public int _PresentingMonth { get; set; }
        public int _SelectedDay { get; set; }
        public int _DaysInMonth { get; set; }
        public string SelectedDate {
            get {
                return string.Format("{0}/{1:00}/{2:00}", _PresentingYear, _PresentingMonth, _SelectedDay);
            }
        }
        public DateTime SelectedDateGreGorian
        {
            get
            {
                return new System.Globalization.PersianCalendar().ToDateTime(_PresentingYear, _PresentingMonth, _SelectedDay, 0, 0, 0, 0);
            }
        }
        public FarsiDatePicker()
        {
            var pc = new System.Globalization.PersianCalendar();
            InitializeComponent();
            format = new StringFormat();
            //format.LineAlignment = StringAlignment.Center;
            //format.Alignment = StringAlignment.Center;
            //format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            this.BackColor = BackColor;
            _PresentingMonth = pc.GetMonth(DateTime.Now);
            _PresentingYear = pc.GetYear(DateTime.Now);
            _SelectedDay = pc.GetDayOfMonth(DateTime.Now);
        }
        public bool NextMonth() //TODO: nex month when reaches to next year not works
        {
            var pc = new System.Globalization.PersianCalendar();
            if (_PresentingMonth == 12)
            {
                _PresentingMonth = 1;
                _PresentingYear ++;
            }
            else
                _PresentingMonth++;
            this.Refresh();
            EventArgs e = new EventArgs();
            if (OnSelectedDayChanged != null)
                OnSelectedDayChanged(this, e);
            return true;
        }
        public bool PreviousMonth()
        {
            var pc = new System.Globalization.PersianCalendar();
            if (_PresentingMonth == 1)
            {
                _PresentingMonth = 12;
                _PresentingYear --;
            }
            else
                _PresentingMonth--;
            this.Refresh();
            EventArgs e = new EventArgs();
            if (OnSelectedDayChanged != null)
                OnSelectedDayChanged(this, e);
            return true;
        }
        public void GoToDate(int year,int month,int day)
        {
            _PresentingYear = year;
            _PresentingMonth = month;
            _SelectedDay = day;

            this.Refresh();
            //SelectDay(_SelectedDay);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var pc = new System.Globalization.PersianCalendar();
            
            Brush b = new SolidBrush(CTodayFullDate);
            
            e.Graphics.DrawString(PersianDateTime.Months[_PresentingMonth], new Font("iransansweb", 12), b, this.Width-10, 20, new StringFormat(StringFormatFlags.DirectionRightToLeft));
            e.Graphics.DrawString("امروز: "+Culture.ConvertNumerals(PersianDateTime.GetPersianDate(DateTime.Now)).ToString(), new Font("iransansweb", 18), b, 2, this.Height-40,format);
            _DaysInMonth = pc.GetDaysInMonth(_PresentingYear, _PresentingMonth);
            int interval = this.Width / 7;
            int Hinterval = this.Height / 5;
            int c;
            int r;
            for (int i = 1; i <= _DaysInMonth; i++)
            {
                c = i % 7;
                r = (int)(i / 7);

                var v = PersianDateTime.GetDaOfWeek(_PresentingYear, _PresentingMonth, i);
                 b = new SolidBrush(CWorkingDayColor);
                if (v == 7)
                    b =new  SolidBrush(CNoneWorkingDayColor);
                {
                    e.Graphics.DrawString(PersianDateTime.WeekDayNames[v], new Font("iransansweb", 9), b, this.Width - (c * interval + interval / 2 + 25), r * Hinterval + Hinterval / 3 + 17,format);
                    int x = this.Width - (c * interval + interval / 2 + 15), 
                        y = r * Hinterval + Hinterval / 4;
                    e.Graphics.DrawString(Culture.ConvertNumerals(i.ToString()), new Font("iransansweb", 16),b, x, y,format);
                    if (pc.ToDateTime(_PresentingYear, _PresentingMonth, i, 23, 59, 0, 0) < DateTime.Now)
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), x - 5, y + 5, x + 25, y + 35);
                }
            }
            int today = pc.GetDayOfMonth(DateTime.Now) + 1;
            int toyear= pc.GetYear(DateTime.Now) ;
            int tomonth= pc.GetMonth(DateTime.Now) ;
            c = today % 7;
            r = (int)(today / 7);
            if (tomonth == _PresentingMonth && toyear == _PresentingYear)
                DrawRoundedRectangle(e.Graphics, new Pen(CTodayRectColor, 1), new Rectangle(this.Width - (c * interval + 0), r * Hinterval + 8, interval - 4, Hinterval - 4), 5);
        }

        void SelectDay(int day)
        {
            
            int c, r;

            var v = PersianDateTime.GetDaOfWeek(_PresentingYear, _PresentingMonth, day);
            Brush b = new SolidBrush(CWorkingDayColor);

            int interval = this.Width / 7;
            int Hinterval = this.Height / 5;
            c = day % 7;
            r = (int)(day / 7);
            DrawRoundedRectangle(this.CreateGraphics(), new Pen(Color.GreenYellow, 2), new Rectangle(this.Width - (c * interval + 0), r * Hinterval + 8, interval - 4, Hinterval - 4), 5);
        }
        public string GetSelectedDate(bool persian=true)
        {
            return string.Format("{0}/{1:00}/{2:00}",_PresentingYear,_PresentingMonth,_SelectedDay);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);//Chartreuse

            draw(0, Color.GreenYellow, rectLineWidth:2);
            if (OnSelectedDayChanged != null)
                OnSelectedDayChanged(this, e);

        }
        public event EventHandler OnSelectedDayChanged;
        void draw(int DesiredDay,Color clr,int rectLineWidth=1)
        {
            
            int interval = this.Width / 7;
            int Hinterval = this.Height / 5;
            
            Point p = new Point(Cursor.Position.X, Cursor.Position.Y);
            p = new Point(this.PointToClient(p).X, this.PointToClient(p).Y);
            int c = p.X / interval;
            int r = p.Y / Hinterval;

            int temp = r * 7 + 6-c;
            if (temp > 0 && temp <= _DaysInMonth)
            {
                
                    
                _SelectedDay = temp;
                // this.CreateGraphics().DrawRectangle(new Pen(Color.HotPink, 2), c * interval, r * Hinterval, interval, Hinterval);
                this.Refresh();
                DrawRoundedRectangle(this.CreateGraphics(), new Pen(clr, rectLineWidth), new Rectangle(c * interval + 4, r * Hinterval + 8, interval - 4, Hinterval - 4), 5);
            }
        }

        void drawTodayRect()
        {
            //int today=new 
            //int c = i % 7;
            //int r = (int)(i / 7);
        }
        public GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        public  void DrawRoundedRectangle(Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (pen == null)
                throw new ArgumentNullException("pen");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius))
            {
                graphics.DrawPath(pen, path);
            }
        }
    }
}
