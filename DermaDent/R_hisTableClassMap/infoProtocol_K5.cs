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
    
    public partial class infoProtocol_K5
    {
        public decimal ID { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> id_insur { get; set; }
        public Nullable<int> id_K { get; set; }
        public Nullable<decimal> Mab { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
    
        public virtual info_K5 info_K5 { get; set; }
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual insur insur { get; set; }
    }
}
