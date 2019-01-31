using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaDent
{
    public class PersianDateTime
    {
        public PersianDateTime(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public static int GetDaOfWeek(int year, int month, int day)
        {
            DateTime dt = new System.Globalization.PersianCalendar().ToDateTime(year, month, day, 12, 00, 00, 00);

            int dayow = (int) new System.Globalization.PersianCalendar().GetDayOfWeek(dt);
            dayow += 2;
            if (dayow > 7)
                dayow -= 7;
            return dayow;
             
        }
        public int Year { get; set; }
        public int Month
        {
            get; set;
            //get
            //{
            //    return Month;
            //}
            //set
            //{
            //    if (value < 1||value>12)
            //        return;
            //    else Month= value;
            //}
        }
        public int Day
        {
            get; set;
            //get
            //{
            //    return Day;
            //}
            //set {
            //    if (value < 1)
            //        return;
            //    if (Month > 6 && value > 30 )
            //        return;
            //    if (value > 31)
            //        return;
            //    else Day = value;
            //}
        }
        public static string GetDayOfWeekName(DateTime PD)
        {
            int day = (int)PD.DayOfWeek;
            day += 2;
            if (day > 7)
                day -= 7;
            return WeekDayNames[day];
        }
        public static int GetMonth(DateTime PD) { return new System.Globalization.PersianCalendar().GetMonth(PD); }
        public static int GetDayOfMonth(DateTime PD)
        {
            return new System.Globalization.PersianCalendar().GetDayOfMonth(PD);
        }
        public static int GetDatOfWeekNo(DateTime PD)
        {
            int day = (int)PD.DayOfWeek;
            day += 2;
            if (day > 7)
                day -= 7;
            return day;
        }
        public static int GetDatOfWeek(PersianDateTime PD)
        {
            return (int)(new System.Globalization.PersianCalendar().ToDateTime(PD.Year, PD.Month, PD.Day, 12, 0, 0, 0).DayOfWeek);
        }
        //public static int GetDayOfWeek(int year,int month,int day)
        //{
        //    return (int)(new System.Globalization.PersianCalendar().ToDateTime(PD.Year, PD.Month, PD.Day, 12, 0, 0, 0).DayOfWeek);
        //}
        //public static string GetDayOfWeekString(int year, int month, int day)
        //{
        //    return (int)(new System.Globalization.PersianCalendar().ToDateTime(PD.Year, PD.Month, PD.Day, 12, 0, 0, 0).DayOfWeek);
        //}
        public static string[] WeekDayNames = { "شناور",
                                                "شنبه",
                                                "یکشنبه",
                                                "دوشنبه",
                                                "سشنبه",
                                                "چهارشنبه",
                                                "پنجشنبه",
                                                "جمعه" };
        public static string GetPersianDate(DateTime dt)
        {
            var pc = new System.Globalization.PersianCalendar();
            return string.Format("{0}/{1:00}/{2:00}", pc.GetYear(dt), pc.GetMonth(dt), pc.GetDayOfMonth(dt));
        }

        public static string[] Months = { "",
        "فروردین",
        "اردیبهشت",
        "خرداد",
        "تیر",
        "مرداد",
        "شهریور",
        "مهر",
        "آبان",
        "آذر",
        "دی",
        "بهمن",
        "اسفند"};
    }

}
