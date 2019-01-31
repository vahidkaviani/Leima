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
    
    public partial class HISFamilyDocQuesionMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HISFamilyDocQuesionMaster()
        {
            this.HISFamilyDocQuesionDetails = new HashSet<HISFamilyDocQuesionDetail>();
            this.HISFamilyDocQuesionPersons = new HashSet<HISFamilyDocQuesionPerson>();
        }
    
        public decimal QuesionCode { get; set; }
        public Nullable<decimal> QuesionCodeSub { get; set; }
        public string QuesionDesc { get; set; }
        public Nullable<int> ConditionAgeFrom { get; set; }
        public Nullable<int> ConditionAgeTo { get; set; }
        public Nullable<byte> ConditionSex { get; set; }
        public byte Flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISFamilyDocQuesionDetail> HISFamilyDocQuesionDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISFamilyDocQuesionPerson> HISFamilyDocQuesionPersons { get; set; }
    }
}
