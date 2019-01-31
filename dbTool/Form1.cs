using Solident;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class papro
        {
            public papro(string name,string family ,string id) { fname = name;lname = family;this.id = id; }
            public string fname { get; set; }
            public string lname { get; set; }
            public string id { get; set; }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            // switch case is the easy way, a hash or map would be better, 
            // but more work to get set up.
            switch (keyData)
            {
                case Keys.F10:
                    crc();
                    bHandled = true;
                    break;
                case Keys.F6:
                    Update();
                    bHandled = true;
                    break;
                case Keys.F5:
                    Run();
                    bHandled = true;
                    break;
                case Keys.F4:
                    execQuery();
                    bHandled = true;
                    break;
            }
            return bHandled;
        }
        string getcrc(string data)
        {
            byte[] retval = { 0xFF };
            for (int i = 0; i < data.Length/2; i++)
            {
                string bts = data.Substring(i * 2, 2);
                byte tmp = byte.Parse(bts, System.Globalization.NumberStyles.HexNumber);
                retval[0] ^= tmp;
            }
            return BitConverter.ToString(retval).Replace("-", "");
        }
        private void crc()
        {
            string[] ids = textBox1.Text.Replace("\r", "").Split('\n');
            List<string> memid = new List<string>();
            for (int i = 0; i < ids.Length; i++)
            {
                if (string.IsNullOrEmpty(ids[i]))
                    continue;
                string crc = getcrc(ids[i].Substring(0,8));
                memid.Add(ids[i] + crc);
            }
            string res = "";
            for (int i = 0; i <memid.Count; i++)
            {
                res += memid[i] + "\r\n";
            }
            textBox1.Text = res;
        }

        Dictionary<string,papro> get_PList()
        {
            Dictionary<string, papro> retval = new Dictionary<string, papro>();
            var v = new DatabaseManager().GetData("SELECT IDSick,FNameSick,LNameSick FROM InfoSick");
            dataGridView1.DataSource = v;
            for (int i = 0; i < v.Rows.Count; i++)
            {
                string pid = v.Rows[i]["IDSick"].ToString();
                string n = v.Rows[i]["FNameSick"].ToString();
                string f= v.Rows[i]["LNameSick"].ToString();
                retval.Add(pid, new papro(pid, n, f));
            }
            return retval;
        }
        void edit_database_pa(papro p)
        {
            new DatabaseManager().SaveData(string.Format("UPDATE InfoSick SET FNameSick='{0}',LNameSick='{1}' WHERE IDsick='{2}'",p.fname,p.lname,p.id));
        }
        void Update()
        {
            if (MessageBox.Show("Are you Sure?","Attention!!!",MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                return;
            //if(textBox1.Text.Contains("WHERE",))
            //if (MessageBox.Show("Are you Sure?") != DialogResult.OK)
            //    return;
            string[] datas = textBox1.Text.Split('\n');
            Dictionary<string, papro> list = new Dictionary<string, papro>();

            for (int i = 0; i < datas.Length; i++)
            {
                if (string.IsNullOrEmpty(datas[i]))
                    continue;
                string[] ptemp = datas[i].Replace("\r", "").Split('\t');
                list.Add(ptemp[0], new papro(ptemp[1], ptemp[2], ptemp[0]));
            }
            //dataGridView1.DataSource = list.Values.ToArray();
            var dbdata = get_PList();
            List<papro> UpdateList = new List<papro>();
            foreach (var item in list)
            {
                //if (!item.Value.fname.Contains("NoName") || !item.Value.lname.Contains("NoName"))
                //    continue;
                if (dbdata.ContainsKey(item.Key))
                {
                    UpdateList.Add(item.Value);
                    edit_database_pa(item.Value);
                }
            }
            dataGridView1.DataSource = UpdateList;
        }
        void execQuery()
        {
            var v = new DatabaseManager().GetData(textBox1.Text);
            dataGridView1.DataSource = v;
        }
        private void Run()
        {
            string[] datas = textBox1.Text.Split('\n');
            Dictionary<string, papro> list = new Dictionary<string, papro>();

            for (int i = 0; i < datas.Length; i++)
            {
                if (string.IsNullOrEmpty(datas[i]))
                    continue;
                string[] ptemp = datas[i].Replace("\r", "").Split('\t');
                list.Add(ptemp[0], new papro(ptemp[0], ptemp[1], ptemp[2]));
            }
            dataGridView1.DataSource = list.Values.ToArray();
        }
    }
}
