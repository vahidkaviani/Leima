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
    
    public partial class Queue_paz
    {
        public decimal ID { get; set; }
        public Nullable<int> centerid { get; set; }
        public Nullable<decimal> ID_nobat { get; set; }
        public Nullable<int> id_software { get; set; }
        public Nullable<int> id_section { get; set; }
        public string sex { get; set; }
        public Nullable<byte> Flag { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string D_CalledQueue { get; set; }
        public string T_CalledQueue { get; set; }
        public Nullable<bool> isCalledQueue { get; set; }
        public Nullable<byte> IsAbsentQueue { get; set; }
        public string T_AbsentQueue { get; set; }
        public string D_CalledQueue_Sono { get; set; }
        public string T_CalledQueue_Sono { get; set; }
        public Nullable<byte> Type_Queue { get; set; }
        public string pass { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual InfoRadio InfoRadio { get; set; }
        public virtual InfoSoftware InfoSoftware { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}
