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
    
    public partial class family_doc_Template_Detail
    {
        public decimal id_detail { get; set; }
        public Nullable<decimal> id_master { get; set; }
        public Nullable<decimal> id_service { get; set; }
        public Nullable<decimal> code_manual { get; set; }
        public string nameservice { get; set; }
        public Nullable<decimal> count_tajviz { get; set; }
    
        public virtual family_doc_Template_Master family_doc_Template_Master { get; set; }
    }
}
