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
    
    public partial class infoProtocol_Mokamel_Master2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public infoProtocol_Mokamel_Master2()
        {
            this.infoProtocol_Mokamel_Detail_insur2 = new HashSet<infoProtocol_Mokamel_Detail_insur2>();
            this.infoProtocol_Mokamel_Detail2 = new HashSet<infoProtocol_Mokamel_Detail2>();
        }
    
        public decimal RuleID { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> id_insur_Mokamel { get; set; }
        public string D_Run { get; set; }
        public string D_Expire { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoProtocol_Mokamel_Detail_insur2> infoProtocol_Mokamel_Detail_insur2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoProtocol_Mokamel_Detail2> infoProtocol_Mokamel_Detail2 { get; set; }
        public virtual Infouser Infouser { get; set; }
        public virtual insur insur { get; set; }
    }
}
