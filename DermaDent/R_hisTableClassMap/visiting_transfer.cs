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
    
    public partial class visiting_transfer
    {
        public decimal ID { get; set; }
        public Nullable<decimal> kindidRelFrom { get; set; }
        public Nullable<decimal> kindidRelTo { get; set; }
        public Nullable<decimal> id_user_trans { get; set; }
        public string date_edit_trans { get; set; }
        public string time_edit_trans { get; set; }
    
        public virtual Infouser Infouser { get; set; }
        public virtual visiting visiting { get; set; }
        public virtual visiting visiting1 { get; set; }
    }
}