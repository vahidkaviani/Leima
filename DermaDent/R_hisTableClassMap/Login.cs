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
    
    public partial class Login
    {
        public decimal idlogin { get; set; }
        public decimal RowID { get; set; }
        public string LoginDate { get; set; }
        public Nullable<int> CenterID { get; set; }
        public string IP { get; set; }
        public string LoginTime { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}
