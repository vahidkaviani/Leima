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
    
    public partial class FamilyDoctorDetail_Lab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FamilyDoctorDetail_Lab()
        {
            this.FamilyDoctorDetail_LabResult = new HashSet<FamilyDoctorDetail_LabResult>();
        }
    
        public decimal ID { get; set; }
        public Nullable<decimal> ID_FamilyDoctorMaster { get; set; }
        public Nullable<decimal> id_service { get; set; }
        public Nullable<byte> Is_Paziresh { get; set; }
        public Nullable<bool> Is_Ok_Org { get; set; }
        public Nullable<decimal> Online_Mab_Illness { get; set; }
        public Nullable<decimal> Online_Mab_Org { get; set; }
        public Nullable<decimal> Online_Mab_Service { get; set; }
        public Nullable<int> id_Markaz_Erayeh { get; set; }
        public string Date_Erayeh { get; set; }
        public Nullable<decimal> ID_SazmanOnline { get; set; }
        public Nullable<int> id_software { get; set; }
        public Nullable<decimal> count_print { get; set; }
    
        public virtual FamilyDoctorMaster FamilyDoctorMaster { get; set; }
        public virtual InfoTest InfoTest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FamilyDoctorDetail_LabResult> FamilyDoctorDetail_LabResult { get; set; }
    }
}
