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
    
    public partial class SendBimehFizio
    {
        public decimal id { get; set; }
        public Nullable<decimal> code_ozv { get; set; }
        public string code_send { get; set; }
        public Nullable<decimal> id_insur { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<decimal> id_user { get; set; }
    
        public virtual infoozv infoozv { get; set; }
        public virtual Infouser Infouser { get; set; }
        public virtual insur insur { get; set; }
    }
}
