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
    
    public partial class result_radio
    {
        public decimal kindid { get; set; }
        public decimal code { get; set; }
        public string result { get; set; }
        public string file_path { get; set; }
        public decimal rowid { get; set; }
        public Nullable<bool> concat_files { get; set; }
        public decimal KindidRel { get; set; }
    
        public virtual Paziresh4 Paziresh4 { get; set; }
    }
}