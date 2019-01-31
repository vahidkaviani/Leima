using DermaDent.Bot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
//using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types.ReplyMarkups;
using static System.Net.Mime.MediaTypeNames;

namespace DSoftShopcheeBot
{
    public struct stateTask
    {
        public int SateID;
        public int StateGroupID;
        public string stateName;
        public int NextState;
        public string NextQuestion;
    }
    public struct state
    {
        public int last;
        public int current;
        public string answer;
        public DateTime LastAction;
        public int Page;
    }
    class SQLServerTH
    {
        public void InitUserStateAtHome(int id)
        {
            DatabaseManager dbm = new DatabaseManager();
            dbm.SaveData("insert into UserCommandState (TelegramAssignedID,LastState,CurrentState,LastAnswer,LastActionTime,CurrentFunctionHandler,LastPage) VALUES ('" + id.ToString() + "','-1','11',' ','" + DateTime.Now+ "','null',0)");
        }

        public void UpdateUserCommandState(int id, int nextState, int LastState, string answer, int page)
        {
            DatabaseManager dbm = new DatabaseManager();
            dbm.SaveData("UPDATE UserCommandState SET CurrentState=" + nextState.ToString() + ", LastState=" + LastState.ToString() + ", LastAnswer=N'" + answer + "', LastActionTime='" + DateTime.Now.ToString() + "', LastPage=" + page.ToString() + " WHERE TelegramAssignedID=" + id.ToString());
        }


        public string GetUserRealName(int id)
        {
            DatabaseManager dbm = new DatabaseManager();
            string query = "Select * from UserProfile WHERE UserProfile.TelegramAssignedID=" + id.ToString()+" AND Finished='1'";
            var result=dbm.GetData(query);
            if (result.Rows.Count > 0)
                return result.Rows[0]["UserFirstName"].ToString()+" " + result.Rows[0]["UserLastName"].ToString();
            return null; 
        }

        public List<List<KeyboardButton>> GetKeyBoardDetails(int kbid)
        {
            List<List<KeyboardButton>> res = new List<List<KeyboardButton>>();
            int counter = 0;

            DatabaseManager dbm = new DatabaseManager();
            var result = dbm.GetData("SELECT * FROM [Key] Where  KeyBoardID =" + kbid.ToString() + " ORDER BY 'ROW' ASC , 'COLUMN' ASC");
            if (result.Rows.Count>0)
            {
                while (counter<result.Rows.Count)
                {
                    if (res.Count < (int)result.Rows[counter]["Row"] + 1)
                        res.Add(new List<KeyboardButton>());
                    res[(int)result.Rows[counter]["Row"]].Add(new KeyboardButton((string)result.Rows[counter]["Text"]));
                    counter++;
                }
            }
            return res;
        }
     public List<List<InlineKeyboardButton>> GetInlineKeyBoardDetails(int kbid)
        {
            List<List<InlineKeyboardButton>> res = new List<List<InlineKeyboardButton>>();
            int counter = 0;

            DatabaseManager dbm = new DatabaseManager();
            var result = dbm.GetData("SELECT * FROM [Key] Where  KeyBoardID =" + kbid.ToString() + " ORDER BY 'ROW' ASC , 'COLUMN' ASC");
            if (result.Rows.Count>0)
            {
                while (counter<result.Rows.Count)
                {
                    if (res.Count < (int)result.Rows[counter]["Row"] + 1)
                        res.Add(new List<InlineKeyboardButton>());
                    res[(int)result.Rows[counter]["Row"]].Add((new InlineKeyboardButton() { Text=(string)result.Rows[counter]["Text"] }));
                    counter++;
                }
            }
            return res;
        }
        public string GetKeyBoardText(int kbid)
        {
            DatabaseManager dbm = new DatabaseManager();
            var result=dbm.GetData("SELECT * FROM KeyBoards WHERE KeyBoardID= " + kbid.ToString());
            if (result.Rows.Count > 0)
                if (result.Rows[0]["KeyboardText"] != DBNull.Value)
                    return result.Rows[0]["KeyboardText"].ToString();
            return null;
        }

        public DataTable GetDataByFilter(string TableName,string[] FieldsName,string[] filtersFieldName, string[] filtersFieldValue)
        {
            DatabaseManager dm = new DatabaseManager();
            string SelectiveFields = "";
            for (int i = 0; i < FieldsName.Length-1; i++)
            {
                SelectiveFields += (FieldsName + ",");
            }
            SelectiveFields += FieldsName[FieldsName.Length-1];

            string Filter = "";
            for (int i = 0; i <  filtersFieldName.Length-1; i++)
            {
                Filter += ("("+filtersFieldName[i]+"='"+filtersFieldValue[i]+"') AND");
            }
            Filter += ("(" + filtersFieldName[filtersFieldName.Length - 1] + "='" + filtersFieldValue[filtersFieldName.Length - 1] + "')");

            string qry = string.Format("SELECT {0} FROM {1} WHERE {2}", SelectiveFields, TableName, Filter);
            return dm.GetData(qry);
        }
        public bool IsUserRegisteredBefor(int IdentiFire)
        {
            var result=GetDataByFilter("UserProfile", new string[] { "*" }, new string[] { "TelegramAssignedID", "Finished" }, new string[] { IdentiFire.ToString(), "1" });
            if (result.Rows.Count > 0)
                return true;
            return false;
            
        }

        public List<DR_Charge> GetTodayTransactions(string fromDate = null, string ToDate = null, int DrID = -1, string PatientID = null, int TelegramID = -1)
        {
            if (fromDate == null)
                fromDate = "1390/01/01";
            if(ToDate==null)
                ToDate = "2390/01/01";
            string OtherConditions = "";
            if (PatientID != null)
                OtherConditions = string.Format(" AND ID_Sick='{0}'", PatientID);
            string Query = string.Format(
@" SELECT FNamedentist+' '+LNamedentist AS drname,NameService,datevisit,FNamesick+' ' +LNamesick AS 'Patient',ID_Service,Mab_ghabel_daryaft-visiting.Mab_Additional_Col AS Filtered,(((Mab_ghabel_daryaft-visiting.Mab_Additional_Col)*Infodentist.Per_Porotocol)/100) AS SahmePezeshk,Mab_ghabel_daryaft,visiting.Mab_Additional_Col,t1,t2,t3,t4
FROM visiting
JOIN Infodentist
ON visiting.ID_dentist=Infodentist.IDdentist
JOIN InfoService
ON ID_service=IDService
JOIN InfoSick
ON ID_sick=IDsick
JOIN RobotDrDetail
ON RobotDrDetail.DoctorId=ID_dentist
WHERE flag_delete='0'
AND TelegramID='{0}'
AND datevisit Between '{1}' AND '{2}' 
{3}
ORDER BY IDdentist,datevisit ASC", TelegramID,fromDate,ToDate,OtherConditions);

            //if (!string.IsNullOrEmpty(fromData))
            //    Query += string.Format(" AND datevisit>{0}", fromData);

            //if (!string.IsNullOrEmpty(ToDate))
            //    Query += string.Format(" AND datevisit<{0}", ToDate);

            //if (DrID != -1)
            //    Query += string.Format(" AND IDdentist={0}", DrID);

            //if (!string.IsNullOrEmpty(PatientID))
            //    Query += string.Format(" AND PatientID={0}", PatientID);

            //if (TelegramID != -1)
            //    Query += string.Format(" AND TelegramID={0}", TelegramID);

            var res = new DatabaseManager().GetData(Query);
            string result = string.Empty;
            int sum = 0;
            int tsum = 0;
            List<DR_Charge> ldr = new List<DR_Charge>();
            
            for (int i = 0; i < res.Rows.Count; i++)
            {
                DR_Charge drc = new DR_Charge();
                drc.DrPerCase = (int)(float)res.Rows[i]["SahmePezeshk"];
                drc.patientname = (string)res.Rows[i]["Patient"];
                drc.servicename = (string)res.Rows[i]["NameService"]+ "  " +(string)res.Rows[i]["ID_service"].ToString() ;
                drc.ServicePrice = (int)(decimal)res.Rows[i]["Filtered"];
                drc.t1 = (string)res.Rows[i]["t1"] ;
                drc.t2 = (string)res.Rows[i]["t2"];
                drc.t3 = (string)res.Rows[i]["t3"];
                drc.t4 = (string)res.Rows[i]["t4"];
                drc.VisiteDateTime = (string)res.Rows[i]["datevisit"] ;
                //result += string.Format("{0},{1},{2},{3}\r\n",  res.Rows[i]["PatientName"], 
                //                                                res.Rows[i]["NameService"], 
                //                                                res.Rows[i]["Mab_illness_Col"],
                //                                                res.Rows[i]["DenPer"]);
                sum += (int)(float)res.Rows[i]["SahmePezeshk"];
                tsum += (int)(decimal)res.Rows[i]["Filtered"];
                drc.drName= (string)res.Rows[i]["drname"];
                ldr.Add(drc);
                
            }
            DR_Charge f = new DR_Charge();
            f.servicename = "جمع خدمات و سهم پزشک : ";
            f.DrPerCase = sum;
            f.ServicePrice = tsum;
            ldr.Add(f);
            //result += string.Format("{0}",sum);
            return ldr;
        }

        ///*
        // * -1 means user not stated yet
        // * 999999 means state time out
        // */
        public state GetLastState(int IdentiFire)
        {
            state s = new state();
            DatabaseManager dm = new DatabaseManager();
            var result = dm.GetData("select * from UserCommandState  WHERE TelegramAssignedID='" + IdentiFire.ToString() + "'");

            s.current = -1;
            s.last = -1;
            s.Page = -1;

            if (result.Rows.Count > 0)
            {
                if (result.Rows[0]["LastState"] != DBNull.Value)
                    s.last = (int)result.Rows[0]["LastState"];                           //

                if (result.Rows[0]["CurrentState"] != DBNull.Value)
                    s.current = (int)result.Rows[0]["CurrentState"];                        //

                if (result.Rows[0]["LastAnswer"] != DBNull.Value)
                    s.answer = ((string)result.Rows[0]["LastAnswer"]);                             //

                if (result.Rows[0]["LastActionTime"] != DBNull.Value)
                    s.LastAction = (DateTime)result.Rows[0]["LastActionTime"];     //

                if (result.Rows[0]["LastPage"] != DBNull.Value)
                    s.Page = (int)(result.Rows[0]["LastPage"]);                            //
            }

            return s;
        }

        public stateTask GetStateTask(int STID)
        {
            stateTask task = new stateTask();
            DatabaseManager dm = new DatabaseManager();
            var result = dm.GetData("select * from StateID   WHERE STID=" + STID.ToString());

            if (result.Rows.Count>0)
            {
                if (result.Rows[0]["Question"] != DBNull.Value)
                    task.NextQuestion = result.Rows[0]["Question"].ToString();
                if (result.Rows[0]["NxtState"] != DBNull.Value)
                    task.NextState = (int)result.Rows[0]["NxtState"];    
            }
            return task;
        }

        public void CreateRecord()
        {
            
        }

        public int SaveImage(string PicName,string SavePath,int TelegtamID)
        {
            string qry = string.Format("INSERT INTO {0} ({1},{2},{3},{4}) VALUES ('{5}','{6}','{7}','{8}') ;", "Pic", "PictureName", "savedPath", "TelegramID", "ReceiveTime",
                                                    PicName, SavePath, TelegtamID, DateTime.Now);
            new DatabaseManager().SaveData(qry);
            var result = GetDataByFilter("Pic", new string[] { "*" }, new string[] { "PictureName" }, new string[] { PicName.ToString() });
            if (result.Rows.Count > 0)
                return (int)result.Rows[0]["id"];
            return -1;
        }

        public List<string> GetOrderStateReport(int TelegramID)
        {
            List<string> retval = new List<string>();
            var result = new DatabaseManager().GetData(
                @"SELECT TOP(20) [SCDB].[dbo].[Order].id, [SCDB].[dbo].[Order].Product_Url ,[SCDB].[dbo].[Order].OrderNo,[SCDB].[dbo].OrderStateDetails.details
                FROM [SCDB].[dbo].[Order]
                JOIN [SCDB].[dbo].[OrderStateDetails]
                ON [SCDB].[dbo].[Order].Order_State=[SCDB].[dbo].[OrderStateDetails].[OrderStateID]
                WHERE ([SCDB].[dbo].[Order].Finished='1') AND ([SCDB].[dbo].[Order].[Telegram_Id]='"+TelegramID.ToString()+"');");
            for (int i = 0; i < result.Rows.Count; i++)
            {
                string res = string.Format("شماره:\t{0} \r\n لینک:\t{1}\r\n تعداد:\t{2} \r\nوضعیت:\t{3}\r\n___________________\r\n",
                    result.Rows[i]["id"],
                    result.Rows[i]["Product_Url"],
                    result.Rows[i]["OrderNo"],
                    result.Rows[i]["details"]);
                retval.Add(res);
            }
            retval.Add("_______End____\r\n");
            return retval;
        }
        public void CreateOrCompleteField(string TableName, string FieldName,
                                            string FilterField, string FilterValue,
                                            object value, string secondFilterName = null,
                                            string seccondFilterValue = null,string SeccondFieldName = null,
                                            object SeccondValue=null)
        {
            DatabaseManager dm = new DatabaseManager();
            try
            {
                string query = string.Format("SELECT * FROM {0} WHERE ({1} = '{2}')", TableName, FilterField, FilterValue);

                if (secondFilterName != null && seccondFilterValue != null)
                {
                    query = string.Format(" {0} AND ({1}='{2}')", query, secondFilterName, seccondFilterValue);
                }

                var result = dm.GetData(query);

                if (result.Rows.Count > 0)  // the field exist so we should Update that
                {
                    if (SeccondFieldName != null && SeccondValue != null)
                        query = string.Format("UPDATE {0} SET {1}='{2}',{3}='{4}' WHERE ({5}='{6}')", TableName, FieldName, value, SeccondFieldName, SeccondValue, FilterField, FilterValue);
                    else
                        query = string.Format("UPDATE {0} SET {1}=N'{2}' WHERE ({3}='{4}')", TableName, FieldName, value, FilterField, FilterValue);
                    if (secondFilterName != null && seccondFilterValue != null)
                    {
                        query = string.Format(" {0} AND ({1}='{2}')", query, secondFilterName, seccondFilterValue);
                    }

                    

                    dm.SaveData(query);
                }
                //else // the field not exist so we create that for first time
                //{
                //    if (SeccondFieldName != null && SeccondValue != null)
                //        query = string.Format("UPDATE {0} SET {1}={2},{4}={5} WHERE ({3}={4})", TableName, FieldName, value, FilterField, FilterValue, SeccondFieldName, SeccondValue);
                //    else
                //        query = string.Format("UPDATE {0} SET {1}={2} WHERE ({3}={4})", TableName, FieldName, value, FilterField, FilterValue);
                //    dm.SaveData(query);
                //}
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("scbot"))
                    EventLog.CreateEventSource("database", "Dsoft");
                EventLog.WriteEntry("scbot", ex.Message);
            }
        }

        public List<string> GetUnreadMessage(int Id)
        {
            var result = GetDataByFilter("Message", new string[] { "*" }, new string[] { "RecieverTelegramID" , "Readed" }, new string[] { Id.ToString(),false.ToString() });
            List<string> UnreadMessages = new List<string>();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                UnreadMessages.Add(string.Format("{0}\r\n{1}:\t {2}", result.Rows[i]["MessageRegisterTime"], result.Rows[i]["Sender"], result.Rows[i]["MessageText"]));
            }
            UpdateUnreadMesssageAsRead(Id);
            return UnreadMessages;
        }

        public int GetUnreadMessageCount(int id)
        {
            int retval = 0;

           var result= new DatabaseManager().GetData("SELECT COUNT(*) FROM Message WHERE RecieverTelegramID='" + id.ToString() + "' AND Readed='FALSE'");
            retval =(int) result.Rows[0][0];

            return retval;
        }
        public void UpdateUnreadMesssageAsRead(int id)
        {
            CreateOrCompleteField("Message", "Readed", "RecieverTelegramID", id.ToString(), false.ToString(), "Readed", false.ToString(), "MessageReadTime",DateTime.Now);
        }
        public void RegisterNewMessage(int SenderId=0,string sender=null,string Reciever=null,int RecieverID=0)
        {

        }
        public static void SaveDocumentToDB(string FileName,string DocType)
        {

        }

        public static List<KeyboardButton> GetPatientAsKeyboard(string lName=null, string fName=null)//, DateTime? From, DateTime? To)
        {
            //string text = "";

            //if (fName != null)
            //    text +=  fName + " ";
            ////else if (lName != null)
            ////    lName += "%";
            //if (lName != null)
            //    text += lName+"%";

            string Query = string.Format("SELECT TOP(20) FNameSick,LNameSick,IDsick FROM InfoSick WHERE IDsick<'10000000' AND (FNameSick+' '+LNameSick)  LIKE '%" + lName + "%' ");

            Query += " ORDER BY date_create DESC";

            var result = new DatabaseManager().GetData(Query);

            List<KeyboardButton> btn=new List<KeyboardButton>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                KeyboardButton kb = new KeyboardButton(
                                                        ((decimal)result.Rows[i]["IDsick"]).ToString() + "," +
                                                        (string)result.Rows[i]["FNameSick"] + "," +
                                                        (string)result.Rows[i]["LNameSick"]);
                btn.Add(kb);
            }

            return btn;
        }

    }

    
}
