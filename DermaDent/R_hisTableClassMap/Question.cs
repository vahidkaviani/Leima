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
    
    public partial class Question
    {
        public decimal ID { get; set; }
        public Nullable<int> CenterID { get; set; }
        public string Quesion { get; set; }
        public string Response { get; set; }
        public Nullable<decimal> id_User { get; set; }
        public string Date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<decimal> id_User_Response { get; set; }
        public string Date_Edit_Response { get; set; }
        public string Time_Edit_Response { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual infoCenteral infoCenteral1 { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}