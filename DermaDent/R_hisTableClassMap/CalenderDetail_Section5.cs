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
    
    public partial class CalenderDetail_Section5
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_CalenderMaster5 { get; set; }
        public Nullable<decimal> id_Section { get; set; }
    
        public virtual CalenderMaster5 CalenderMaster5 { get; set; }
        public virtual InfoSection5 InfoSection5 { get; set; }
    }
}
