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
    
    public partial class rpt_SQL_Detail
    {
        public int KindID { get; set; }
        public int rptID { get; set; }
        public int RowID { get; set; }
        public string FieldName { get; set; }
        public string Alias { get; set; }
        public string Caption { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public string FontName { get; set; }
        public Nullable<int> SizeFont { get; set; }
        public bool Bold { get; set; }
        public bool IsSUM { get; set; }
        public bool IsGroup { get; set; }
        public bool IsOrderBy { get; set; }
        public bool IsCount { get; set; }
    
        public virtual rpt_SQL_Master rpt_SQL_Master { get; set; }
    }
}