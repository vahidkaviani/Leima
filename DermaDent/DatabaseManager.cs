using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DSoftShopcheeBot
{
    public class DatabaseManager
    {
        //SqlConnection con = new SqlConnection(DataBaseConnection.dbConnectionString);
        //SqlCommand cmd=new SqlCommand(;
        public DataTable GetData(string Query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(Query, DataBaseConnection.dbConnectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void SaveData(string qry)
        {
            SqlConnection con = new SqlConnection(DataBaseConnection.dbConnectionString);
            SqlCommand cmd = new SqlCommand(qry,con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
              con.Close();
            con.Dispose();
        }
        
    }
}
