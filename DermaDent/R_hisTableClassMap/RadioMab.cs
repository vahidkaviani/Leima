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
    
    public partial class RadioMab
    {
        public int KindID { get; set; }
        public int Code { get; set; }
        public string D_Run { get; set; }
        public string D_Expire { get; set; }
        public Nullable<decimal> Mab_Dolati { get; set; }
        public Nullable<decimal> Mab_khososi { get; set; }
        public Nullable<decimal> Mab_other1 { get; set; }
        public Nullable<decimal> Mab_other2 { get; set; }
        public Nullable<decimal> Mab_other3 { get; set; }
        public Nullable<decimal> Mab_other4 { get; set; }
        public Nullable<int> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<int> CenterID { get; set; }
    
        public virtual InfoRadio InfoRadio { get; set; }
    }
}