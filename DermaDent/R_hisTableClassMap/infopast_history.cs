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
    
    public partial class infopast_history
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public infopast_history()
        {
            this.IllnessHistory_Past = new HashSet<IllnessHistory_Past>();
        }
    
        public decimal code { get; set; }
        public string name_past { get; set; }
        public Nullable<bool> @checked { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IllnessHistory_Past> IllnessHistory_Past { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}
