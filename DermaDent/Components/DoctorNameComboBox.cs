using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSoftShopcheeBot;

namespace DermaDent
{
    public partial class DoctorNameComboBox : ComboBox
    {
        public static IList<string> drlist=new List<string>();
        public DoctorNameComboBox()
        {
            InitializeComponent();
            if (drlist.Count<1)
                Init();
            this.DataSource = drlist;
        }
        protected void Init()
        {
            this.Items.Clear();
            
            var result = new DatabaseManager().GetData(@"SELECT  IDdentist
                                                                ,LNamedentist
                                                                ,FNamedentist
                                                                FROM Infodentist");

            for (int i = 0; i < result.Rows.Count; i++)
            {
                //this.Items.Add(result.Rows[i][0] + "," + result.Rows[i][1] + "   " + result.Rows[i][2]);
                drlist.Add(result.Rows[i][0] + "," + result.Rows[i][1] + "   " + result.Rows[i][2]);
            }

          //  this.AutoCompleteMode = AutoCompleteMode.Suggest;
          //  this.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public int GetDoctorID()
        {
            return int.Parse(((string)this.SelectedItem).Split(',')[0]);
        }

        public string GetDoctorName()
        {
            return (((string)this.SelectedItem).Split(',')[1]);
        }

        
    }
}
