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
    
    public partial class InfoDiagnosi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoDiagnosi()
        {
            this.PatientFirstDetail_Diagnosis = new HashSet<PatientFirstDetail_Diagnosis>();
        }
    
        public int Code { get; set; }
        public string NameDiagnosis { get; set; }
        public string CodeOrg { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<bool> @checked { get; set; }
        public string CodeInterNational { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientFirstDetail_Diagnosis> PatientFirstDetail_Diagnosis { get; set; }
    }
}
