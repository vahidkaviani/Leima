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
    
    public partial class infoProtocol_Mokamel_Detail_insur1
    {
        public decimal ID { get; set; }
        public Nullable<decimal> RuleIDRel { get; set; }
        public Nullable<decimal> id_insur { get; set; }
    
        public virtual infoProtocol_Mokamel_Master1 infoProtocol_Mokamel_Master1 { get; set; }
        public virtual insur insur { get; set; }
    }
}
