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
    
    public partial class PatientFirstMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientFirstMaster()
        {
            this.PatientFirstDetail_Danger = new HashSet<PatientFirstDetail_Danger>();
            this.PatientFirstDetail_Diagnosis = new HashSet<PatientFirstDetail_Diagnosis>();
            this.PatientFirstDetail_Records = new HashSet<PatientFirstDetail_Records>();
            this.PatientFirstDetail_Surgery = new HashSet<PatientFirstDetail_Surgery>();
        }
    
        public decimal ID { get; set; }
        public Nullable<decimal> id_illness { get; set; }
        public string CreateDate { get; set; }
        public Nullable<int> Ghad { get; set; }
        public Nullable<double> Weight { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<byte> RH { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientFirstDetail_Danger> PatientFirstDetail_Danger { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientFirstDetail_Diagnosis> PatientFirstDetail_Diagnosis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientFirstDetail_Records> PatientFirstDetail_Records { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientFirstDetail_Surgery> PatientFirstDetail_Surgery { get; set; }
    }
}
