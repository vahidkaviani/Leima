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
    
    public partial class Paziresh2_DetailResult
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_Paziresh2_Detail1 { get; set; }
        public string Result { get; set; }
        public Nullable<decimal> id_UserResult { get; set; }
        public string D_Result { get; set; }
        public string Time_Result { get; set; }
        public string ReCheck { get; set; }
        public Nullable<bool> concat_files { get; set; }
        public string file_path { get; set; }
    
        public virtual Infouser Infouser { get; set; }
        public virtual Paziresh2_Detail1 Paziresh2_Detail1 { get; set; }
    }
}
