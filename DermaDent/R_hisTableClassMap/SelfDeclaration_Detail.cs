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
    
    public partial class SelfDeclaration_Detail
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_SelfDeclaration_Master { get; set; }
        public Nullable<int> id_SelfDeclaration { get; set; }
        public Nullable<bool> Result_Yes { get; set; }
        public Nullable<bool> Result_No { get; set; }
        public string Comment { get; set; }
    
        public virtual SelfDeclaration_Master SelfDeclaration_Master { get; set; }
        public virtual SelfDeclaration_Quesion SelfDeclaration_Quesion { get; set; }
    }
}
