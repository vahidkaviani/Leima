using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent
{
    public partial class CurrentDateTimePersian : UserControl
    {
        public CurrentDateTimePersian()
        {
            InitializeComponent();
            Updater.Interval = 1000;
            Updater.Start();
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            LBLDayOfWeek.Text = PersianDateTime.GetDayOfWeekName(DateTime.Now);
            LBLDate.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            LBLTime.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
