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
    
    public partial class Payment_Software
    {
        public decimal ID { get; set; }
        public int id_software { get; set; }
        public int CenterID { get; set; }
        public string date_payment { get; set; }
        public Nullable<decimal> Mab_payment { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> D_Or_P { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_Edit { get; set; }
        public string time_Edit { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual InfoSoftware InfoSoftware { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}
