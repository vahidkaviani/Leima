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
    
    public partial class IllnessHistory_Detail3
    {
        public decimal id_sick { get; set; }
        public Nullable<int> RowID { get; set; }
        public decimal id_question { get; set; }
        public string reply { get; set; }
        public Nullable<bool> yesno { get; set; }
    
        public virtual Infoquestion Infoquestion { get; set; }
        public virtual InfoSick InfoSick { get; set; }
    }
}
