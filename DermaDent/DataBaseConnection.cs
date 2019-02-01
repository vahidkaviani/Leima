using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSoftShopcheeBot
{
    public class DataBaseConnection
    {
        public static string dbConnectionString
        {
            get
            {
                //return string.Format("Server={0};Database={1};Trusted_Connection=True;", ".\\dsoftdb", "R_his");
#if DEBUG
                return string.Format("Server={0};Database={1};Trusted_Connection=True;", ".\\DSOFTCLINIC", "R_his");
                //return string.Format("Server={0};Database={1};Trusted_Connection=True;", ".", "R_his");
                //return string.Format("Server={0};Database={1};Trusted_Connection=True;", ".\\dsoftdb", "R_his");
#else
                 //return string.Format("Server={0};Database={1};Trusted_Connection=True;", ".", "R_his");
               return string.Format("Server={0};Database={1};Trusted_Connection=True;", ".\\DSOFTCLINIC", "R_his");
                return string.Format("Server={0};Database={1};Trusted_Connection=True;", ".", "R_his");
                return string.Format("Server={0};Database={1};Trusted_Connection=True;", ".", "DSHIS");
#endif
                //return "data source=.; initial catalog=SCDB; integrated security=True;";
                //return "Server=localhostt;Database=SCDB;user id=vch;Password =9092301020; ";
                //return "Server = JAVAN-PC; Database = SCDB; User Id = vch;Password = 9092301020;";

            }
        }
    }
}
