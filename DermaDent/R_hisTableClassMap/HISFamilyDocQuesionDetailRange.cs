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
    
    public partial class HISFamilyDocQuesionDetailRange
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_HISFamilyDocQuesionDetail { get; set; }
        public Nullable<double> ConditionRangeFrom { get; set; }
        public Nullable<double> ConditionRangeTo { get; set; }
    
        public virtual HISFamilyDocQuesionDetail HISFamilyDocQuesionDetail { get; set; }
    }
}
