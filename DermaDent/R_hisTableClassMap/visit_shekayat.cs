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
    
    public partial class visit_shekayat
    {
        public decimal KindID { get; set; }
        public int RowID { get; set; }
        public Nullable<decimal> id_illness { get; set; }
        public Nullable<int> Code { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<decimal> id_doctor { get; set; }
    
        public virtual visit5 visit5 { get; set; }
    }
}
