using DermaDent.Document;
using DermaDent.FormsV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        

        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show(" یک نسخه در حال اجرا می باشد");
                    return;
                }



#if DEBUG
                Application.Run(new FRMDeclareServices());
                FRMAuthentication frm = new FRMAuthentication();
                return;
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
                Application.Run(new FRMHomePage(frm.SU_));
                Application.Run(new FRMTimeDivision());

                Application.Run(new FRMDeclareServices ());
                Application.Run(new FRMDiagnosisTreatmentPlan());
                return;
                Application.Run(new FRMReserverdTime());
                return;
                //Application.Run(new FRMBotManager());
                Application.Run(new FRMPatientInfo());
               // Application.Run(new FRMHomePage());
#else
            FRMAuthentication frm = new FRMAuthentication();
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
                Application.Run(new FRMHomePage(frm.SU_));
                frm.Dispose();
#endif
            }
        }
    }
}
