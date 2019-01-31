using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DermaDent
{
    public partial class PersianDateTimeBox : MaskedTextBox
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public PersianDateTimeBox()
        {
            //InitializeComponent();
            this.Mask = "0000/00/00";
            this.Text = "____/__/__";
            this.Font = new Font("Tahoma", 11);
        }
        PersianCalendar pc = new PersianCalendar();
        public bool BadFormat { get; set; }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            string[] date = Text.Split('/');

            int day, month, year;
            BadFormat = int.TryParse(date[0], out year);

            if (!BadFormat)
                return;

            BadFormat = int.TryParse(date[1], out month);
            if (!BadFormat)
                return;

            BadFormat = int.TryParse(date[2], out day);
            if (!BadFormat)
                return;

            if (day > 31 || day < 1 || month > 12 || month < 1)
                return;

            BadFormat = false;
            //DateTime dt = new DateTime(year, month, day, pc);
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
        public DateTime SelectedDate
        {
            get
            {
                string[] date = Text.Split('/');
                bool t;
                int day = 0, month = 0, year = 0;
                t = int.TryParse(date[0], out year);
                if (!t)
                    return DateTime.Now;
                t = int.TryParse(date[1], out month);
                if (!t)
                    return DateTime.Now; ;
                t = int.TryParse(date[2], out day);
                if (!t)
                    return DateTime.Now; ;

                if (day > 31 || day < 1 || month > 12 || month < 1)
                    return DateTime.Now;


                DateTime dt = new DateTime(year, month, day, pc);
                return dt;
            }

        }
    }
}
