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
    
    public partial class tarhdarman
    {
        public decimal ID_Illness { get; set; }
        public decimal RowID { get; set; }
        public Nullable<decimal> id_typeSpecial { get; set; }
        public Nullable<decimal> id_service { get; set; }
        public Nullable<decimal> ID_dentist { get; set; }
        public string t1 { get; set; }
        public string t2 { get; set; }
        public string t3 { get; set; }
        public string t4 { get; set; }
        public string descript { get; set; }
        public Nullable<decimal> Mab { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<decimal> ID_User { get; set; }
        public Nullable<int> CenterID { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}
