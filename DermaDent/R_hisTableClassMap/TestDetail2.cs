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
    
    public partial class TestDetail2
    {
        public decimal Kindid { get; set; }
        public decimal Rowid { get; set; }
        public decimal Code { get; set; }
        public int CenterID { get; set; }
        public string Range { get; set; }
        public decimal CurrentRow { get; set; }
        public Nullable<decimal> ID_User { get; set; }
        public string Date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<decimal> ID_UserDelete { get; set; }
        public string date_delete { get; set; }
        public string Time_delete { get; set; }
        public string HotKey { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}
