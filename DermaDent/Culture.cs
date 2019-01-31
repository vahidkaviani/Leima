using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DermaDent
{
    class Culture
    {
        public static string[] FarsiNo = { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };
        public static string ConvertNumerals(string input)
        {
            
                return input.Replace('0', '\u06f0')
                        .Replace('1', '\u06f1')
                        .Replace('2', '\u06f2')
                        .Replace('3', '\u06f3')
                        .Replace('4', '\u06f4')
                        .Replace('5', '\u06f5')
                        .Replace('6', '\u06f6')
                        .Replace('7', '\u06f7')
                        .Replace('8', '\u06f8')
                        .Replace('9', '\u06f9');
        }
    }
}
