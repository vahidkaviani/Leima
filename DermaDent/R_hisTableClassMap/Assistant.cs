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
    
    public partial class Assistant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assistant()
        {
            this.Rule_Salary_assistant = new HashSet<Rule_Salary_assistant>();
            this.Visiting_Assistant = new HashSet<Visiting_Assistant>();
        }
    
        public decimal id { get; set; }
        public string assistant1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rule_Salary_assistant> Rule_Salary_assistant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visiting_Assistant> Visiting_Assistant { get; set; }
    }
}