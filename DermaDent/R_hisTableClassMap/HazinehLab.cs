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
    
    public partial class HazinehLab
    {
        public decimal idHazineh { get; set; }
        public string date_sabt { get; set; }
        public string sharh { get; set; }
        public Nullable<decimal> id_visit { get; set; }
        public string date_visit { get; set; }
        public Nullable<decimal> id_service { get; set; }
        public string t1 { get; set; }
        public string t2 { get; set; }
        public string t3 { get; set; }
        public string t4 { get; set; }
        public Nullable<decimal> id_Lab { get; set; }
        public string dat { get; set; }
        public string date_tah { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> Mab { get; set; }
        public Nullable<decimal> Mab_Pay_Lab { get; set; }
        public Nullable<decimal> id_Sick { get; set; }
        public Nullable<decimal> id_dentist { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string name_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> Mab_illness_Material { get; set; }
        public Nullable<decimal> Mab_Org { get; set; }
        public Nullable<float> Per_illness_Lab { get; set; }
        public Nullable<decimal> Mab_Lab_Col { get; set; }
        public Nullable<decimal> Per_Org_Lab { get; set; }
        public Nullable<int> WorkTypeId { get; set; }
        public Nullable<decimal> KindidRel { get; set; }
        public string date_tasvieh { get; set; }
        public Nullable<decimal> count_khedmat { get; set; }
        public Nullable<decimal> mab_khedmat_from_pro { get; set; }
        public Nullable<decimal> mab_takhfif { get; set; }
        public string comment_takhfif { get; set; }
        public Nullable<decimal> id_noekar { get; set; }
        public Nullable<bool> result_tahvil { get; set; }
        public Nullable<bool> result_erja { get; set; }
        public string date_erja_mojadad { get; set; }
        public string date_tahvil_mojadad { get; set; }
        public string date_tahvile_real { get; set; }
        public string comment { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}
