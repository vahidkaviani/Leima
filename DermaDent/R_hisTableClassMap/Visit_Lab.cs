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
    
    public partial class Visit_Lab
    {
        public decimal KindID { get; set; }
        public int IdNoskheh { get; set; }
        public int RowID { get; set; }
        public Nullable<decimal> Id_Illness { get; set; }
        public Nullable<int> Code { get; set; }
        public string Result { get; set; }
        public string Date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<byte> Flag { get; set; }
        public string Comment { get; set; }
        public string DateLab { get; set; }
        public string NormalRange { get; set; }
        public string CodeRah { get; set; }
        public string UnitName { get; set; }
        public Nullable<decimal> IDSazman { get; set; }
        public Nullable<decimal> Online_Mab_Illness { get; set; }
        public Nullable<decimal> Online_Mab_Org { get; set; }
        public Nullable<decimal> Online_Mab_Service { get; set; }
        public Nullable<decimal> Online_Tedad_Mojaz_tajviz { get; set; }
    
        public virtual visit5 visit5 { get; set; }
    }
}