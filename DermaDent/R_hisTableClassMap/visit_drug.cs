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
    
    public partial class visit_drug
    {
        public decimal KindID { get; set; }
        public int IDNoskheh { get; set; }
        public int RowID { get; set; }
        public Nullable<decimal> id_illness { get; set; }
        public Nullable<int> Code { get; set; }
        public Nullable<int> IDRoute { get; set; }
        public string days { get; set; }
        public string days_Stop { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Id_Tanavob { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<byte> flag { get; set; }
        public Nullable<decimal> cnt_drug { get; set; }
        public Nullable<decimal> CodeRah { get; set; }
        public Nullable<decimal> IDSazman { get; set; }
        public Nullable<decimal> Online_Mab_Illness { get; set; }
        public Nullable<decimal> Online_Mab_Org { get; set; }
        public Nullable<decimal> Online_Mab_Service { get; set; }
        public Nullable<decimal> Online_Tedad_Mojaz_tajviz { get; set; }
    
        public virtual visit5 visit5 { get; set; }
    }
}
