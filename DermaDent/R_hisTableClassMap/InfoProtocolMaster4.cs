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
    
    public partial class InfoProtocolMaster4
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoProtocolMaster4()
        {
            this.InfoProtocolDetail_Center4 = new HashSet<InfoProtocolDetail_Center4>();
            this.InfoProtocolDetail4 = new HashSet<InfoProtocolDetail4>();
        }
    
        public decimal RuleID { get; set; }
        public Nullable<decimal> id_Insur { get; set; }
        public Nullable<int> CenterID { get; set; }
        public string D_Run { get; set; }
        public string D_Expire { get; set; }
        public string Code_Send_Bimeh { get; set; }
        public string code_kind_markaz { get; set; }
        public string FileNameSend { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoProtocolDetail_Center4> InfoProtocolDetail_Center4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoProtocolDetail4> InfoProtocolDetail4 { get; set; }
        public virtual Infouser Infouser { get; set; }
        public virtual insur insur { get; set; }
    }
}