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
    
    public partial class RuleSalaryDetail_Service564
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_RuleSalaryMaster564 { get; set; }
        public Nullable<decimal> id_service { get; set; }
        public Nullable<decimal> Per_MabService { get; set; }
        public Nullable<decimal> Per_MabMaterial { get; set; }
        public Nullable<decimal> Per_MabLab { get; set; }
        public Nullable<decimal> Per_MabAdditional { get; set; }
    
        public virtual infoService infoService { get; set; }
        public virtual RuleSalaryMaster564 RuleSalaryMaster564 { get; set; }
    }
}