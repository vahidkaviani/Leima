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
    
    public partial class InsurService
    {
        public decimal id_insur { get; set; }
        public string IDService { get; set; }
        public string NameService { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public string GroupService { get; set; }
        public Nullable<int> IDSub { get; set; }
        public string Timeservice { get; set; }
        public Nullable<bool> fix { get; set; }
        public Nullable<int> idindex { get; set; }
        public string NodePtr { get; set; }
        public Nullable<int> CenterID { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}
