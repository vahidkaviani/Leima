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
    
    public partial class Rule_serviceS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rule_serviceS()
        {
            this.Rule_serviceS_detail_dependent = new HashSet<Rule_serviceS_detail_dependent>();
            this.Rule_serviceS_detail_insur = new HashSet<Rule_serviceS_detail_insur>();
            this.Rule_serviceS_detail = new HashSet<Rule_serviceS_detail>();
        }
    
        public decimal ID { get; set; }
        public string from_date { get; set; }
        public string to_date { get; set; }
        public Nullable<bool> checked_dent { get; set; }
        public Nullable<byte> Flag_day_month { get; set; }
        public Nullable<int> day { get; set; }
        public Nullable<bool> checked_centerid { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<bool> checked_cnt_dent { get; set; }
        public Nullable<decimal> count_dent { get; set; }
        public string t1 { get; set; }
        public string t2 { get; set; }
        public string t3 { get; set; }
        public string t4 { get; set; }
        public Nullable<bool> checked_dentist { get; set; }
        public Nullable<bool> checked_noskhe { get; set; }
        public Nullable<decimal> count_noskhe { get; set; }
        public string to_date_warning { get; set; }
    
        public virtual Infouser Infouser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rule_serviceS_detail_dependent> Rule_serviceS_detail_dependent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rule_serviceS_detail_insur> Rule_serviceS_detail_insur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rule_serviceS_detail> Rule_serviceS_detail { get; set; }
    }
}
