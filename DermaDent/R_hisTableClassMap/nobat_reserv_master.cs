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
    
    public partial class nobat_reserv_master
    {
        public decimal id { get; set; }
        public Nullable<decimal> id_software { get; set; }
        public Nullable<decimal> id_doctor { get; set; }
        public Nullable<int> centerid { get; set; }
        public Nullable<int> zarib { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}