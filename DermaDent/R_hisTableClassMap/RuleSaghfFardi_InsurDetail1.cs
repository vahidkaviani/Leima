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
    
    public partial class RuleSaghfFardi_InsurDetail1
    {
        public decimal ID { get; set; }
        public Nullable<decimal> RuleID_Master { get; set; }
        public Nullable<decimal> id_insur { get; set; }
    
        public virtual insur insur { get; set; }
        public virtual RuleSaghfFardi1 RuleSaghfFardi1 { get; set; }
    }
}
