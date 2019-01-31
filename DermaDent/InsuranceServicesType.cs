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
    public partial class InsuranceServicesType : ComboBox
    {
        public InsuranceServicesType()
        {
           // InitializeComponent();
            //Init();
           
        }
        protected void Init()
        {
            this.Items.Clear();
            var result = new DatabaseManager().GetData(@"SELECT Code,NameTypeService FROM infoTypeService5");

            for (int i = 0; i < result.Rows.Count; i++)
            {
                this.Items.Add(result.Rows[i][0].ToString() + ',' + result.Rows[i][1]);
            }

            //  this.AutoCompleteMode = AutoCompleteMode.Suggest;
            //  this.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public int GetServiceTypeID()
        {
            return int.Parse(((string)this.SelectedItem).Split(',')[0]);
        }

        public string GetServiceTypeName()
        {
            return (((string)this.SelectedItem).Split(',')[1]);
        }


    }
}
