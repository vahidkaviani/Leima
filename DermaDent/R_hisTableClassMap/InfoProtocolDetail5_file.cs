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
    
    public partial class InfoProtocolDetail5_file
    {
        public decimal ruleid { get; set; }
        public int centerid { get; set; }
        public string code_markaz { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<decimal> id_user { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}
