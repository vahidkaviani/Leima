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
    
    public partial class Family_Responsibele
    {
        public decimal ID { get; set; }
        public Nullable<decimal> Id_question { get; set; }
        public Nullable<decimal> Code_responsible { get; set; }
    
        public virtual Family_Question_doc Family_Question_doc { get; set; }
    }
}