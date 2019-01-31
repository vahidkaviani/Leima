using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent
{
    class ProfeciencyCombobox:ComboBox
    {
        public ProfeciencyCombobox()
        {
             init();
        }

        protected void init()
        {
            var result = Transaction.GetTarribesGroupList();
            this.Items.Clear();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                string s = result.Rows[i]["IDTypespecial"].ToString()+"," + (string)result.Rows[i]["NameTypespecial"];
                this.Items.Add(s);
            }
        }

        public int GetProfeciencyType()
        {
            int pro = 0;
            try
            {
                pro=int.Parse(((string)(this.SelectedItem)).Split(',')[0]);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return pro;
        }
    }
}
