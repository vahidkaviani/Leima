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
    
    public partial class checkup_lab
    {
        public int id_checkup { get; set; }
        public string descript { get; set; }
        public string F_date { get; set; }
        public string T_date { get; set; }
        public Nullable<decimal> max_cnt_paz { get; set; }
        public Nullable<bool> cancel_flag { get; set; }
        public Nullable<int> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<bool> Checked { get; set; }
        public Nullable<byte> group_no { get; set; }
    }
}
