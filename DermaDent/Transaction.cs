using DSoftShopcheeBot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DermaDent
{
    public struct TreatmentServiceItem
    {
        public int ServiceCode;
        public string servicename;
        public string DoctorID;
        public int profeciencytype;
        public int ServicePrice;
        public string PatientID;
        public string Tooth;
        public float DrSharePercent;
        public float DrshareFinal;
        public int SystemOffPriceValue;
        public int DrOffPriceValue;
        public int InvoiceID;
    }

    public struct SoftwareUserInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
    }
    public struct PatientProfileST
    {
        public string FileID { get; set; }
        public DateTime BirthDay { get; set; }
        public string PersianBirthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public int VIPGroup { get; set; }
    }
    class Transaction
    {
        public static bool RegisterVisitTime(   int DoctorID
                                                ,string ServiceName 
                                                ,string PersianDate
                                                ,TimeSpan TimeToVisit
                                                ,bool SendMessage
                                                ,short Status
                                                ,int ServiceCode
                                                ,string PatientID
                                                ,string ToothNo
                                                ,DateTime? ReservingTime)
        {
            var tool = new DatabaseManager();
            var result=tool.GetData(string.Format("SELECT * FROM VisitTime WHERE {0}='{1}' AND {2}='{3}' AND {4}='{5}' AND {6}='{7}'","DoctorID",DoctorID,"PersianDate",PersianDate,"Status",Status,"TimeToVisit",TimeToVisit));
            if (result.Rows.Count > 0)
                return false;
            if (!ReservingTime.HasValue)
                ReservingTime = DateTime.Now;
            tool.SaveData(string.Format("INSERT INTO VisitTime(DoctorID,ServiceName,PersianDate,SendMessage,Status,ServiceCode,PatientID,ToothNo,TimeToVisit,ReservedTime) VALUES('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}')"
                , DoctorID,
                ServiceName,
                PersianDate,
                SendMessage,
                Status,
                ServiceCode,
                PatientID,
                ToothNo,
                TimeToVisit,
                ReservingTime));
            return true;//if the time has no conflict
        }

        public static DataTable GetServicesListAndInfo()
        {
            string Query = string.Format(@"SELECT * FROM infoService");
            return new DatabaseManager().GetData(Query);
        }

        public static DataTable GetDiagnosesList()
        {
            string Query = string.Format(@"SELECT * FROM InfoDiagnosis");
            return new DatabaseManager().GetData(Query);
        }
        public static void DeleteDiag(int code)
        {
            string Query = string.Format(@"DELETE InfoDiagnosis WHERE Code='{0}'",code);
            new DatabaseManager().SaveData(Query);
        }
        public static void CreatNewDiagnoses(string DiagName)
        {
            string Query = string.Format(@"INSERT INTO InfoDiagnosis(NameDiagnosis) VALUES ('{0}')", DiagName);
            new DatabaseManager().SaveData(Query);
        }
        public static DataTable ExecutSuctomQuery(string Query)
        {
            try
            {
                return new DatabaseManager().GetData(Query);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public static DataTable GetReservedTime( string From
                                                ,string To
                                                ,int DoctorID=-1
                                                ,string PatientID=null
                                                ,int status=-1
                                                ,string PFirstName=null
                                                ,string PLastName = null
                                                ,bool OnlyAllocated=false)
        {

            //if (From < DateTime.Now)
            //    From = DateTime.Now;
        string Query =/*,[Status]
                                                        ,test.FNamedentist
                                                        ,test.LNamedentist 
                                                        ,test.DoctorID*/
                                                        string.Format(@"SELECT id,convert(char(5),TimeToVisit ,108) [time],PatientID,FNamesick,LNamesick,ServiceName,TelQuick,InfoSick.Tel,ToothNo,PersianDate AS Tarikh,FNameDentist+' '+LNameDentist AS Dentist,Status,FNamesick+' '+LNamesick AS Patient
                                                        ,SendMessage
                                                        FROM VisitTime
                                                        JOIN InfoSick
                                                        ON PatientID=IDsick
                                                        JOIN Infodentist
                                                        ON DoctorID=IDdentist
                                                        WHERE 
                                                        PersianDate BETWEEN '{0}' AND '{1}'"
                                                        , From
                                                        , To);

            if (DoctorID > 0)
                Query += " AND DoctorID='" + DoctorID.ToString() + "'";

            if (!string.IsNullOrEmpty(PatientID))
                Query += " AND PatientID='" + PatientID + "'";

            if (status > 0)
                Query += " AND [Status]='" + status.ToString() + "'";

            if (!string.IsNullOrEmpty(PFirstName))
                Query += " AND FNameSick LIKE '%" + PFirstName + "%'";

            if (!string.IsNullOrEmpty(PLastName))
                Query += " AND LNameSick LIKE '%" + PLastName+ "%'";

            if (OnlyAllocated)
                Query += " AND PatientID != '0'";

            Query += " ORDER BY PersianDate,TimeToVisit";

            var result = new DatabaseManager().GetData(Query);
            
            return result;
        }

        public static DataTable GetOveralViewOfVisitedTime(string From
                                                , string To
                                                , int DoctorID = -1
                                                , string PatientID = null
                                                , int status = -1
                                                , string PatientFirstName= null
                                                , string PatientLastName = null)
        {

            string Query =
                                                        string.Format(@"SELECT
                                                        InfoSick.FNamesick  
                                                        ,InfoSick.LNamesick
                                                        ,test.FNamedentist
                                                        ,test.LNamedentist
                                                        ,test.ServiceName
                                                        ,[Status]
                                                        ,test.Reservedtime
                                                        ,test.ToothNo
                                                        ,test.PatientID
                                                        ,InfoSick.Tel
                                                        ,test.id
                                                        from
                                                        (select	ServiceName
                                                        ,id
                                                        ,DoctorID
                                                        ,[Status]
                                                        ,PatientID
                                                        ,Reservedtime
                                                        ,ToothNo
                                                        ,Infodentist.FNamedentist
                                                        ,Infodentist.LNamedentist
                                                        FROM VisitTime 
                                                        JOIN Infodentist
                                                        ON Infodentist.IDdentist=[VisitTime].DoctorID 
                                                        ) as test
                                                        JOIN InfoSick
                                                        ON InfoSick.IDsick=test.PatientID
                                                        WHERE 
                                                        PersianDate BETWEEN '{0}' AND '{1}'"
                                                        , From
                                                        , To);

            if (DoctorID > 0)
                Query += " AND test.DoctorID='" + DoctorID.ToString() + "'";

            if (!string.IsNullOrEmpty(PatientID))
                Query += " AND test.PatientID='" + PatientID + "'";

            if (status > 0)
                Query += " AND test.[Status]='" + status.ToString() + "'";


            if (!string.IsNullOrEmpty(PatientLastName))
                Query += " AND InfoSick.LNamesick LIKE '%" + PatientLastName + "%' ";

            if (!string.IsNullOrEmpty(PatientFirstName))
                Query += " AND InfoSick.FNamesick LIKE '%" + PatientFirstName + "%' ";
            Query += "\r\n ORDER BY Reservedtime DESC";

            var result = new DatabaseManager().GetData(Query);

            return result;
        }
    
        public static int GetTelegramID(int doctorID)
        {
            int retval = -1;
            var result = new DatabaseManager().GetData(string.Format("SELECT TelegramID FROM InfoDentist WHERE IDdentist='{0}'", doctorID));
            if (result.Rows.Count > 0)
                retval = (int)((long)result.Rows[0]["TelegramID"]);
            return retval;
        }

        public static bool EditVisitTimeState(string ID,string PatientID=null,string drid=null, string status = null,string ToothNo=null,string PersianDate=null,TimeSpan? t=null,string desc=null)
        {
            string query = string.Format("UPDATE VisitTime SET ReservedTime=ReservedTime ");

            if (string.IsNullOrEmpty(PatientID) && string.IsNullOrEmpty(drid) && string.IsNullOrEmpty(status)&&string.IsNullOrEmpty(desc) && string.IsNullOrEmpty(ToothNo)&&string .IsNullOrEmpty(PersianDate)&&!t.HasValue)
                return false;

            if (!string.IsNullOrEmpty(drid))
                query += string.Format(", [DoctorID]='{0}'", drid);

            if (!string.IsNullOrEmpty(PatientID))
                query += string.Format(", [PatientID]='{0}'", PatientID);

            if (!string.IsNullOrEmpty(status))
                query += string.Format(", [Status]='{0}'", status);

            if (!string.IsNullOrEmpty(ToothNo))
                query += string.Format(", [ToothNo]='{0}'", ToothNo);

            if (!string.IsNullOrEmpty(PersianDate))
                query += string.Format(", [PersianDate]='{0}'", PersianDate);

            if (t.HasValue)
                query += string.Format(", [TimeToVisit]='{0}'", t);

            if (!string.IsNullOrEmpty(desc))
                query += string.Format(", [ServiceName]='{0}'", desc);

            query += string.Format(" WHERE id='{0}'", ID);

            new DatabaseManager().SaveData(query);

            return true;
        }
        public static void UpdateVisitTimeState(string ID,int status)
        {
            string query = string.Format("UPDATE VisitTime SET [Status]='{0}' WHERE id='{1}'", status, ID);
            new DatabaseManager().SaveData(query);
        }
        public static PatientProfileST GetLastPatient()
        {
            string QUERY = @"SELECT TOP(1)* FROM InfoSick ORDER BY date_create DESC";
            var res = new DatabaseManager().GetData(QUERY);
            if (res.Rows.Count < 1)
                return new PatientProfileST();
            return new PatientProfileST {
                FirstName = (string)res.Rows[0]["FNamesick"],
                LastName = (string)res.Rows[0]["LNamesick"],
                FileID = res.Rows[0]["IDSick"].ToString(),
                Tel= (string)res.Rows[0]["Tel"],
                Mobile= (string)res.Rows[0]["TelQuick"],
                NationalCode = (string)res.Rows[0]["meliCode"],
                Address = (string)res.Rows[0]["addr"],
                VIPGroup = (int)(decimal)res.Rows[0]["sub"],
                PersianBirthday = (string)res.Rows[0]["Birthday"]
            };
        }
        public static DataTable GetPatientList(string FirstName=null, string LastName = null, string FileID=null,string FromDate=null,string ToDate=null,string meliCode=null)
        {
            string QUERY = @"SELECT TOP(1000)[IDsick]
      ,[FNamesick]
      ,[LNamesick]
      ,[FNamesick]+' '+[LNamesick] AS Patient
      ,[sex]
      ,[meliCode]
      ,[Birthday]
      ,[addr]
      ,[Tel]
      ,[TelQuick]
      ,[Email]
      ,[date_create]
      ,[Father] 
	  ,[identifier]
      ,[marrried_single]
      ,[comment]
      ,[job_location]
      ,[name_user]
      ,[Birthday_city]
        FROM InfoSick WHERE IDsick>'-1'"; //TODO: correct the query
                            
            //if (lName != null )
            //{
            //    QUERY += " AND LNameSick Like '%" + lName + "%' ";
            //}
            if (!string.IsNullOrEmpty(FirstName))
            {
                QUERY += " AND FNameSick Like '%" + FirstName + "%' ";
            }
            if (!string.IsNullOrEmpty(LastName))
            {
                QUERY += " AND LNameSick Like '%" + LastName + "%' ";
            }
            if (!string.IsNullOrEmpty(FileID))
            {
                QUERY += " AND IDsick = '" + FileID + "' ";
            }
            if (!string.IsNullOrEmpty(meliCode ))
            {
                QUERY += " AND meliCode = '" + meliCode + "' ";
            }
            //if (FromDate!= null)
            //{
            //    QUERY += " AND date_create = '" + FileID + "' ";
            //}

            QUERY += "\r\nORDER BY date_create DESC"; 
            return new DatabaseManager().GetData(QUERY);
        }


        public DataTable GetDataByFilter(string TableName, string[] FieldsName, string[] filtersFieldName, string[] filtersFieldValue)
        {
            DatabaseManager dm = new DatabaseManager();
            string SelectiveFields = "";
            for (int i = 0; i < FieldsName.Length - 1; i++)
            {
                SelectiveFields += (FieldsName + ",");
            }
            SelectiveFields += FieldsName[FieldsName.Length - 1];

            string Filter = "";
            for (int i = 0; i < filtersFieldName.Length - 1; i++)
            {
                Filter += ("(" + filtersFieldName[i] + "=N'" + filtersFieldValue[i] + "') AND");
            }
            Filter += ("(" + filtersFieldName[filtersFieldName.Length - 1] + "=N'" + filtersFieldValue[filtersFieldName.Length - 1] + "')");

            string qry = string.Format("SELECT {0} FROM {1} WHERE {2}", SelectiveFields, TableName, Filter);
            return dm.GetData(qry);
        }

        public static List<string> GetVisitTimeList(int TelegramID,string From,string To)
        {
            string query=string.Format(@"SELECT ServiceName,ReservedTime,PatientID,ToothNo ,FNamesick,LNamesick
                                 FROM
                                (SELECT ServiceName,ReservedTime,PatientID,ToothNo 
                                FROM VisitTime

                                JOIN RobotDrDetail

                                ON VisitTime.DoctorID=RobotDrDetail.DoctorId

                                WHERE RobotDrDetail.TelegramId='{0}'

                                AND PersianDate BETWEEN '{1}' AND '{2}') AS temp

                                JOIN InfoSick

                                ON InfoSick.IDsick=PatientID", TelegramID,From,To);
            var result = new DatabaseManager().GetData(query);

            List<string> retVal = new List<string>();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DateTime tmp = (DateTime)result.Rows[i]["ReservedTime"];
                //string s = string.Format("{0}\r\n{1}   {2}\r\n{3}\r\n{4}\r\n{5}",PersianDateTime.GetPersianDate(tmp)
                //                                                    ,PersianDateTime.GetDayOfWeekName(tmp)
                //                                                    ,tmp.ToString("HH:MM")
                //                                                    , (string)result.Rows[i]["FNamesick"]+" "+(string)result.Rows[i]["LNamesick"]
                //                                                    , (string)result.Rows[i]["PatientID"]
                //                                                    , (string)result.Rows[i]["ServiceName"]
                //                                                    );
                string s = string.Format("ساعت : {2} {3}\r\n {6}: {5}", PersianDateTime.GetPersianDate(tmp)
                                                        , PersianDateTime.GetDayOfWeekName(tmp)
                                                        , tmp.ToString("HH:mm")
                                                        , (string)result.Rows[i]["FNamesick"] + " " + (string)result.Rows[i]["LNamesick"]
                                                        , (string)result.Rows[i]["PatientID"]
                                                        , (string)result.Rows[i]["ServiceName"]
                                                        ,"دندان "+ SimpleQuadrant.GetToothMapFrom((string)result.Rows[i]["ToothNo"])
                                                        );
                retVal.Add(s);
            }

            return retVal;
        }

        public static DataTable GetDoctorList()
        {
            return new DatabaseManager().GetData("SELECT IDDentist,FnameDentist,LnameDentist FROM Infodentist");
        }

        public static void registerDoctorPresentTime(string DID, TimeSpan a, TimeSpan b,int day)
        {
            string query = string.Format(@"INSERT INTO DentistPresentTime (Active,DentistID,RegisterTime,StartFromTime,ToEndTime,[WeekDay]) 
                                            VALUES('1','{0}',GETDATE(),'{1}','{2}','{3}')"
                                            , DID, a, b, day);
            new DatabaseManager().SaveData(query);
        }

        public static DataTable GetDoctorPresentTime(   string id=null,
                                                        string weekDay=null)
        {
            string Query = @"SELECT Infodentist.FNamedentist
                                                        ,Infodentist.LNamedentist
                                                        ,Infodentist.IDdentist
                                                        ,DentistPresentTime.id
                                                        ,DentistPresentTime.StartFromTime
                                                        ,DentistPresentTime.ToEndTime
                                                        ,DentistPresentTime.[WeekDay]
                                                        FROM Infodentist
                                                        JOIN DentistPresentTime
                                                        ON DentistPresentTime.DentistID=Infodentist.IDdentist
                                                        WHERE DentistPresentTime.Active='1' ";
            if (weekDay != null)
                Query += "AND (DentistPresentTime.[WeekDay]='" + weekDay + "'  OR DentistPresentTime.[WeekDay]='0')";
            if (id != null)
                Query += " AND DentistPresentTime.DentistID='" + id + "'";
            return new DatabaseManager().GetData(Query);
                                                        
        }

        public static int GetPaiaibleValue(DateTime? From, DateTime? To, int? PID = -1)
        {
            string Query = string.Format("SELECT * FROM InvoiceElement WHERE ");

            if (!To.HasValue)
                To = DateTime.Now.AddDays(1);
            if (!From.HasValue)
                From = DateTime.Now.AddYears(-10);
            if (From.HasValue)
                Query = string.Format("{0} {1} BETWEEN '{2}' AND '{3}' ", Query, "DesiredPayTime", From, To);
            if (PID.HasValue)
                Query = string.Format("{0}   AND PatientID='{1}'", Query, PID);
            var res = new DatabaseManager().GetData(Query);
            int retval = 0;
            for (int i = 0; i < res.Rows.Count; i++)
            {
                retval += (int)res.Rows[i]["PatientPayableValue"];
            }
            return retval;
        }
        public static DataTable GetPatientCheckout(DateTime? From,DateTime? To, int? PID = -1)
        {
            string Query = string.Format("SELECT * FROM InvoiceElement WHERE ");

            if (!To.HasValue)
                To = DateTime.Now.AddDays(1);
            if (!From.HasValue)
                From = DateTime.Now.AddYears(-10);
            if (From.HasValue)
                Query = string.Format("{0} {1} BETWEEN '{2}' AND '{3}' ", Query, "DesiredPayTime",From,To);
            if (PID.HasValue)
                Query = string.Format("{0}   AND PatientID='{1}'", Query, PID);
            return new DatabaseManager().GetData(Query);
        }

        public static void DisabledoctorPresentTime(string DoctorID=null,int ID=-1,int weekday=-1)
        {
            string Query = "UPDATE DentistPresentTime SET Active='0' WHERE Active='1'";

            if (DoctorID!=null)
            {
                Query += " AND DentistID='" + DoctorID + "' ";
            }
            if (ID>=0)
            {
                Query += " AND id='" + ID.ToString() + "' ";
            }
            if (weekday>=0)
            {
                Query += " AND [WeekDay]='" + weekday.ToString() + "' ";
            }

            new DatabaseManager().SaveData(Query);
        }

        public static DataTable GetVisitTimeDetail(int id)
        {
            string Query = string.Format("SELECT * FROM VisitTime WHERE Id='{0}'", id);
            return new DatabaseManager().GetData(Query);
        }
        public static DataTable GetTarribesGroupList()
        {
            string Query = string.Format("SELECT IDTypespecial,NameTypespecial FROM InfoTypespecial");
            return new DatabaseManager().GetData(Query);
        }

        public static DataTable GetDoctorDetails(int ID)
        {
            string Query = string.Format("SELECT * FROM InfoDentist WHERE IDDentist='{0}'",ID);
            return new DatabaseManager().GetData(Query);
        }

        public static int GetServicePrice(int ServiceCode, int? ProfeciencyType = -1, string DoctorID = null)
        {
            string query = string.Format("SELECT * FROM InfoProtocol WHERE ID_Service='{0}' ", ServiceCode);
            if (ProfeciencyType.HasValue)
            {
                query += " AND ID_Typespecial='" + ProfeciencyType + "'";
            }
            if (DoctorID!=null)
            {
                var res = GetDoctorDetails(int.Parse(DoctorID));

                ProfeciencyType = (int)res.Rows[0]["id_typeSpecial"];

                query += " AND ID_Typespecial='" + ProfeciencyType + "'";
            }
            int price = -1;
            var result = new DatabaseManager().GetData(query);
            if (result.Rows.Count > 0)
                price = (int)(decimal)result.Rows[0]["Mab_Service"];
            return price;
        }
        
        public static void RegisterNewInvoiceElement(TreatmentServiceItem t,DateTime DesiredPaytime,string RegisteryUser,int InvoiceHeaderNo)
        {
            int PatientPayableValue = t.ServicePrice - t.SystemOffPriceValue - t.DrOffPriceValue;

            string Query = string.Format(@"INSERT INTO [InvoiceElement](	  
                                               [ServiceName]
                                              ,[ServiceID]
                                              ,[PatientID]
                                              ,[DoctorID]
                                              ,[DoctorOff]
                                              ,[SystemOff]
                                              ,[invoiceID]
                                              ,[PatientPayableValue]
                                              ,[DoctorSharePercent]
                                              ,[DoctorFinalShare]
                                              ,[DesiredPayTime]
                                              ,[RegisterTime]
                                              ,[RegisteryUser])

                                                VALUES(   '{0}'
                                                        , '{1}'
                                                        , '{2}'
                                                        , '{3}'
                                                        , '{4}'
                                                        , '{5}'
                                                        , '{6}'
                                                        , '{7}'
                                                        , '{8}'
                                                        , '{9}'
                                                        , '{10}'
                                                        , '{11}'
                                                        , '{12}'
                                                        )",t.servicename
                                                          ,t.ServiceCode
                                                          ,t.PatientID
                                                          ,t.DoctorID
                                                          ,t.DrOffPriceValue
                                                          ,t.SystemOffPriceValue
                                                          ,InvoiceHeaderNo
                                                          , PatientPayableValue
                                                          ,t.DrSharePercent
                                                          ,(int)((t.DrSharePercent * t.ServicePrice)/100.0)
                                                          ,DesiredPaytime
                                                          ,DateTime.Now
                                                          ,RegisteryUser);
            new DatabaseManager().SaveData(Query);
        }

        public static float GetDrshare(int drId)
        {
            var result = GetDoctorDetails(drId);
            return (float)result.Rows[0]["Per_Porotocol"];
        }
        public static int CreateNewInvoiceHeader(int invoiceValue,string CashierID,int PatientID) // the return Value is Invoice id
        {
            string Query = string.Format("INSERT INTO Invoice(InvoiceValue,registerTime,RegisteryUser,PatientID) VALUES('{0}','{1}','{2}','{3}')"
                                                    , invoiceValue, DateTime.Now, CashierID, PatientID);
            new DatabaseManager().SaveData(Query);

            Query = string.Format(@"SELECT TOP(1) id FROM Invoice
                                    WHERE PatientID='{0}'
                                    ORDER BY id DESC",PatientID);

            var result = new DatabaseManager().GetData(Query);
            if (result.Rows.Count > 0)
                return (int)result.Rows[0]["id"];
            return -1;
        }

        public static List<string> GetPatientDocumentList(int id)
        {
            List<string> retval = new List<string>();

            return retval;
        }
        public static void NewPatient(  string name, 
                                        string lname, 
                                        string Inputid,
                                        string sex,
                                        string Birthday,
                                        string address,
                                        string mobile,
                                        string Tel,
                                        string Nationalid,
                                        string fathername,
                                        string RegisterTime,
                                        string reagent,
                                        int    MariageState=0,
                                        string id_user="anonymous",
                                        string comment="",
                                        string jobLocation="",
                                        string BirthPlace="")
        {
            string query = string.Format("INSERT INTO[InfoSick](IDsick,FNamesick,LNamesick,sex,Birthday,addr,TelQuick,Tel,meliCode,Father,date_create,identifier,marrried_single,name_user,comment,job_location,Birthday_city) VALUES('{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}','{6}','{7}','{8}',N'{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')",
                                            Inputid, name, lname, sex, Birthday, address, mobile, Tel, Nationalid, fathername, RegisterTime, reagent, MariageState, id_user, comment, jobLocation,BirthPlace);
            new DatabaseManager().SaveData(query);
        }
        public static void UpdatePatient(   string name,
                                            string lname, 
                                            string Inputid, 
                                            string sex, 
                                            string Birthday, 
                                            string address, 
                                            string mobile, 
                                            string Tel, 
                                            string Nationalid, 
                                            string fathername, 
                                            string RegisterTime,
                                            string reagent,
                                            int MariageState = 0,
                                            string id_user = "anonymous",
                                            string comment = "",
                                            string jobLocation = "",
                                            string BirthPlace = "")
        {
            string query = string.Format(@"UPDATE [InfoSick] SET FNamesick=N'{1}',LNamesick=N'{2}',sex=N'{3}',Birthday='{4}',addr=N'{5}',TelQuick='{6}',Tel='{7}',meliCode='{8}',Father=N'{9}',date_create='{10}',identifier='{11}',marrried_single='{12}',name_user='{13}',comment='{14}',job_location='{15}',Birthday_city='{16}'
                                                        WHERE IDsick='{0}'",
                                                        Inputid, name, lname, sex, Birthday, address, mobile, Tel, Nationalid, fathername, RegisterTime,reagent,MariageState,id_user,comment,jobLocation, BirthPlace);
            new DatabaseManager().SaveData(query);
        }
        public static SoftwareUserInfo AuthenticateUser(string userid,string pass)  // Authenticate user by given user id
        {
            string query = string.Format(@"SELECT * FROM infousers WHERE Iduser='{0}' AND pass='{1}'", userid, pass);
            var result = new DatabaseManager().GetData(query);
            SoftwareUserInfo retval = new SoftwareUserInfo() { id=-1,name=null,password=null};
            if (result.Rows.Count > 0)
            {
                retval.id = (int)(decimal)result.Rows[0]["Iduser"];
                retval.password = pass;
                retval.name = result.Rows[0]["nameuser"].ToString();
                return retval;
            }
            return retval;
        }
    }
}
