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
    
    public partial class SMSMsg
    {
        public decimal ID { get; set; }
        public int id_software { get; set; }
        public int code { get; set; }
        public string descript { get; set; }
        public int CenterID { get; set; }
    
        public virtual InfoSoftware InfoSoftware { get; set; }
    }
}
