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
    
    public partial class Ready4
    {
        public int Code { get; set; }
        public int RowID { get; set; }
        public string descript { get; set; }
        public string FileNameDoc { get; set; }
        public Nullable<int> id_user { get; set; }
        public string date_Edit { get; set; }
        public string time_Edit { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<bool> Checked { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual InfoRadio InfoRadio { get; set; }
    }
}
