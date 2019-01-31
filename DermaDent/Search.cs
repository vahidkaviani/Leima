using DSoftShopcheeBot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaDent
{
    
    class Search
    {
        public List<PatientProfileST> SearchResult = new List<PatientProfileST>();
        public void searchPatintProfileNormal(string LName = null, string FName=null,string FileID = null)
        {
            SearchResult.Clear();
            DataTable result = new DataTable();
            if (LName != null)
            {
                result = new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    ,[date_create]
                                    ,[TelQuick]
                                    ,[addr]
                                    FROM [InfoSick]" +
                                        string.Format("WHERE {0} LIKE '%{1}%' AND {2} LIKE '%{3}%'", "LNamesick", LName, "FNamesick",FName) +
                                    "ORDER BY date_create DESC ");
               
            }
            else if (FileID != null)
            {
                result= new DatabaseManager().GetData(@"SELECT TOP 200 [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    ,[date_create]
                                    ,[TelQuick]
                                    FROM [InfoSick]" + string.Format("WHERE {0} = '{1}'", "IDsick", FileID) +
                                    "ORDER BY date_create DESC "
                                            );

            }
            for (int i = 0; i < result.Rows.Count; i++)
            {
                PatientProfileST pp = new PatientProfileST {FileID = result.Rows[i]["IDsick"].ToString(),
                                                            FirstName=(string)result.Rows[i]["FNamesick"],
                                                            LastName= (string)result.Rows[i]["LNamesick"],
                                                            Tel = (string)result.Rows[i]["Tel"],
                                                            Mobile = (string)result.Rows[i]["TelQuick"],
                                                            Address= (string)result.Rows[i]["addr"],
                                                            PersianBirthday= (string)result.Rows[i]["Birthday"]
                };

                SearchResult.Add(pp);
            }
        }
    }
}
