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
    
    public partial class Infodentist_DetailSection
    {
        public decimal ID { get; set; }
        public decimal id_dentist { get; set; }
        public decimal id_section { get; set; }
        public Nullable<bool> Checked { get; set; }
    
        public virtual Infodentist Infodentist { get; set; }
        public virtual infoService infoService { get; set; }
    }
}
