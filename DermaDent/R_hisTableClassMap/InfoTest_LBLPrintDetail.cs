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
    
    public partial class InfoTest_LBLPrintDetail
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_InfoTest_LBLPrintMaster { get; set; }
        public Nullable<decimal> id_service { get; set; }
        public Nullable<int> RowIDSort { get; set; }
    
        public virtual InfoTest InfoTest { get; set; }
        public virtual InfoTest_LBLPrintMaster InfoTest_LBLPrintMaster { get; set; }
    }
}