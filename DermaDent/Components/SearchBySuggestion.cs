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
    public partial class SearchBySuggestion : UserControl
    {
        AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
        public SearchBySuggestion()
        {
            InitializeComponent();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = acsc;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);
            if (isNumeric)
                textBox1.RightToLeft = RightToLeft.No;
            else
                textBox1.RightToLeft = RightToLeft.Yes;
            if (((TextBox)sender).Text.Trim().Length < 3)
                return;


            if (!isNumeric)
            {
                Search srch = new Search();
                srch.searchPatintProfileNormal(LName: ((TextBox)sender).Text);
                

                foreach (var item in srch.SearchResult)
                {
                    acsc.Add(item.FirstName + ',' + item.LastName + ',' + item.FileID);
                }
                textBox1.AutoCompleteCustomSource = acsc;
                
            }
        }

        private void SearchOnEnter(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Trim().Length < 3)
                return;

            int n;
            bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);
            if (!isNumeric)
                return;


                Search srch = new Search();
                srch.searchPatintProfileNormal(FileID: ((TextBox)sender).Text);
                acsc.Clear();
            foreach (var item in srch.SearchResult)
                {
                    acsc.Add(item.FirstName + ',' + item.LastName + ',' + item.FileID);
                textBox1.AutoCompleteCustomSource = acsc;
            }

        }
    }
}
