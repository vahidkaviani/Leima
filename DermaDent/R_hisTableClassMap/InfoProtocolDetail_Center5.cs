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
    
    public partial class InfoProtocolDetail_Center5
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_RuleID { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> id_insur { get; set; }
        public Nullable<decimal> id_Service { get; set; }
        public Nullable<byte> Per_Mab { get; set; }
        public Nullable<decimal> Per { get; set; }
        public Nullable<decimal> Mab { get; set; }
        public Nullable<decimal> id_takhasos { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual InfoProtocolMaster5 InfoProtocolMaster5 { get; set; }
    }
}
