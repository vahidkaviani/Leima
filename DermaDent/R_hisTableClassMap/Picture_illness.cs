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
    
    public partial class Picture_illness
    {
        public int KindID { get; set; }
        public int CenterID { get; set; }
        public int id_illness { get; set; }
        public decimal RowID { get; set; }
        public int Type { get; set; }
        public byte[] Picture { get; set; }
        public string Time_Edit { get; set; }
        public string Date_Edit { get; set; }
        public Nullable<int> id_User { get; set; }
        public Nullable<int> CurrentRow { get; set; }
        public Nullable<int> Cancel_Flag { get; set; }
        public Nullable<int> id_service { get; set; }
    }
}
