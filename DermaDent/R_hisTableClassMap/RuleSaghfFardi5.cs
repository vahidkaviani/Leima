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
    
    public partial class RuleSaghfFardi5
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RuleSaghfFardi5()
        {
            this.RuleSaghfFardi_InsurDetail5 = new HashSet<RuleSaghfFardi_InsurDetail5>();
            this.RuleSaghfFardi_ServiceDetail5 = new HashSet<RuleSaghfFardi_ServiceDetail5>();
        }
    
        public decimal RuleID { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> id_illness { get; set; }
        public string D_Run { get; set; }
        public string D_Expire { get; set; }
        public Nullable<byte> Flag_All_Insur { get; set; }
        public Nullable<byte> Flag_All_Service { get; set; }
        public Nullable<decimal> Mab_Saghf { get; set; }
        public string LetterNo { get; set; }
        public string Date_Letter { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<decimal> mandeh_saghf { get; set; }
        public Nullable<decimal> id_nahad { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual infonahad infonahad { get; set; }
        public virtual InfoSick InfoSick { get; set; }
        public virtual Infouser Infouser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleSaghfFardi_InsurDetail5> RuleSaghfFardi_InsurDetail5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RuleSaghfFardi_ServiceDetail5> RuleSaghfFardi_ServiceDetail5 { get; set; }
    }
}
