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
    
    public partial class InfoProtocolMaster5
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoProtocolMaster5()
        {
            this.InfoProtocolDetail_Center5 = new HashSet<InfoProtocolDetail_Center5>();
            this.InfoProtocolDetail5 = new HashSet<InfoProtocolDetail5>();
        }
    
        public decimal RuleID { get; set; }
        public Nullable<decimal> id_Insur { get; set; }
        public Nullable<int> CenterID { get; set; }
        public string D_Run { get; set; }
        public string D_Expire { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoProtocolDetail_Center5> InfoProtocolDetail_Center5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoProtocolDetail5> InfoProtocolDetail5 { get; set; }
    }
}
