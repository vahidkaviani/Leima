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
    
    public partial class Queue_User
    {
        public decimal ID { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public Nullable<int> id_software { get; set; }
        public string sex { get; set; }
        public string pass { get; set; }
        public Nullable<int> centerid { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<byte> flag { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual InfoSoftware InfoSoftware { get; set; }
    }
}