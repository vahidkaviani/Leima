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
    
    public partial class infoDaroHasasiatza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public infoDaroHasasiatza()
        {
            this.IllnessHistory_Detail2 = new HashSet<IllnessHistory_Detail2>();
            this.IllnessHistory_Drug_Interaction = new HashSet<IllnessHistory_Drug_Interaction>();
            this.IllnessHistory_Drug_Use = new HashSet<IllnessHistory_Drug_Use>();
        }
    
        public decimal ID { get; set; }
        public string Namedaro { get; set; }
        public Nullable<decimal> Iduser { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<bool> @checked { get; set; }
        public Nullable<int> centerID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IllnessHistory_Detail2> IllnessHistory_Detail2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IllnessHistory_Drug_Interaction> IllnessHistory_Drug_Interaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IllnessHistory_Drug_Use> IllnessHistory_Drug_Use { get; set; }
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}
