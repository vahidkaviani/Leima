//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSoftClinicAssistant
{
    using System;
    using System.Collections.Generic;
    
    public partial class visit
    {
        public int KindID { get; set; }
        public int CenterID { get; set; }
        public int ID_Section { get; set; }
        public int RowID { get; set; }
        public int id_visit { get; set; }
        public string date_visit { get; set; }
        public string ToTime { get; set; }
        public string FromTime { get; set; }
        public int Codepaziresh { get; set; }
        public string datepaziresh { get; set; }
        public Nullable<int> id_illness { get; set; }
        public Nullable<int> id_doctor_FromErja { get; set; }
        public Nullable<int> id_doctor_ToErja { get; set; }
        public string shekayat_List { get; set; }
        public string tashkhis_List { get; set; }
        public string Nazariyeh { get; set; }
        public string Date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<int> id_User { get; set; }
        public Nullable<int> CurrentRow { get; set; }
        public Nullable<int> Cancel_Flag { get; set; }
        public Nullable<decimal> id_doctor { get; set; }
    }
}
