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
    
    public partial class visiting_Material
    {
        public decimal ID { get; set; }
        public Nullable<decimal> KindIDRel { get; set; }
        public Nullable<decimal> id_Material { get; set; }
        public Nullable<double> Cnt { get; set; }
        public Nullable<decimal> Mab { get; set; }
    
        public virtual visiting visiting { get; set; }
    }
}