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
    
    public partial class RuleSalaryMaster1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RuleSalaryMaster1()
        {
            this.RuleSalaryDetail_Service1 = new HashSet<RuleSalaryDetail_Service1>();
        }
    
        public decimal ID { get; set; }
        public Nullable<decimal> id_doctor { get; set; }
        public Nullable<int> CenterID { get; set; }
        public string D_Run { get; set; }
        public string D_Expire { get; set; }
        public Nullable<decimal> Percent_Maliat { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<decimal> id_insur { get; set; }
        public Nullable<decimal> percent_lab_kasr { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual Infodentist Infodentist { get; set; }
        public virtual Infouser Infouser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleSalaryDetail_Service1> RuleSalaryDetail_Service1 { get; set; }
    }
}
