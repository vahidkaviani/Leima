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
    
    public partial class aghsat_master
    {
        public decimal kindid { get; set; }
        public decimal id_illness { get; set; }
        public Nullable<decimal> code_service { get; set; }
        public Nullable<decimal> mab_per { get; set; }
        public Nullable<decimal> mab_rial { get; set; }
        public Nullable<decimal> count_aghsat { get; set; }
        public string date_begin_ghest { get; set; }
        public Nullable<decimal> space_day { get; set; }
        public string datevisit { get; set; }
        public Nullable<decimal> idvisit { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> id_software { get; set; }
        public Nullable<decimal> KindIDRel { get; set; }
        public Nullable<byte> flag_checkfish { get; set; }
        public string date_resid { get; set; }
        public Nullable<decimal> mab_checkfish { get; set; }
        public Nullable<decimal> checkfish_no { get; set; }
        public Nullable<byte> flag_systemi_dasti { get; set; }
        public Nullable<decimal> mab_col_ghabel_daryaft { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}
