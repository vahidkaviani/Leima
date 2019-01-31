using DSoftClinicAssistant;
using DSoftShopcheeBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TableDependency.Enums;
//using TableDependency.EventArgs;
//using TableDependency.SqlClient;

namespace DermaDent.SQLTableTracker
{
    public class dbMonitor
    {
        //SqlTableDependency<Hazineh2> CashPayment;
        //SqlTableDependency<InfoSick> PatientProfileTrack;
        //SqlTableDependency<NobatDetail1> NewVisitTimeAdded;
        public dbMonitor()
        {
            //CashPayment = new SqlTableDependency<Hazineh2>(DataBaseConnection.dbConnectionString);
            //PatientProfileTrack = new SqlTableDependency<InfoSick>(DataBaseConnection.dbConnectionString);//, tableName: "InfoSick");
            //DentistProfileTrack = new SqlTableDependency<Infodentist>(DataBaseConnection.dbConnectionString);//, tableName: "Infodentist");
            //NewVisitTimeAdded = new SqlTableDependency<NobatDetail1>(DataBaseConnection.dbConnectionString);//, tableName: "VisitTimeTable");

            //CashPayment.OnChanged += Hazineh2Chanage;
            //PatientProfileTrack.OnChanged += InfoSickChange;
            //DentistProfileTrack.OnChanged += InfodentistChange;
            //NewVisitTimeAdded.OnChanged += VisitTimeTablechange;
            //CashPayment.Start();
        }
        // private static void Hazineh2Chanage(object sender, RecordChangedEventArgs<Hazineh2> e)
        //{
        //    if (e.ChangeType != ChangeType.None)
        //    {
        //        var changedEntity = e.Entity;
        //    }
        //}
        //private static void InfoSickChange(object sender, RecordChangedEventArgs<InfoSick> e)
        //{
        //    if (e.ChangeType != ChangeType.None)
        //    {
        //        var changedEntity = e.Entity;
        //    }
        //}
        //private static void InfodentistChange(object sender, RecordChangedEventArgs<Infodentist> e)
        //{
        //    Console.WriteLine(Environment.NewLine);
        //    if (e.ChangeType != ChangeType.None)
        //    {
        //        var changedEntity = e.Entity;
        //    }
        //}
        //private static void VisitTimeTablechange(object sender, RecordChangedEventArgs<NobatDetail1> e)
        //{
        //    Console.WriteLine(Environment.NewLine);
        //    if (e.ChangeType != ChangeType.None)
        //    {
        //        var changedEntity = e.Entity;
        //    }
        //}
    }
}
