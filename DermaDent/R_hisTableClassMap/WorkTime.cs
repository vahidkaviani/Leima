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
    
    public partial class WorkTime
    {
        public int id_software { get; set; }
        public int Code { get; set; }
        public int RowID { get; set; }
        public string descript { get; set; }
        public string Ftime { get; set; }
        public string Ttime { get; set; }
        public Nullable<byte> Days { get; set; }
        public Nullable<int> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<bool> Checked { get; set; }
    }
}
