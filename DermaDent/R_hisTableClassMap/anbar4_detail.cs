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
    
    public partial class anbar4_detail
    {
        public decimal KindID { get; set; }
        public Nullable<decimal> RowID { get; set; }
        public string date_Expire { get; set; }
        public Nullable<int> Code { get; set; }
        public Nullable<decimal> Size { get; set; }
        public Nullable<decimal> Fee { get; set; }
        public Nullable<decimal> Mab_Material { get; set; }
        public Nullable<byte> Flag { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string descript_emha { get; set; }
    
        public virtual anbar4 anbar4 { get; set; }
    }
}
