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
    
    public partial class info_K5
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public info_K5()
        {
            this.infoProtocol_K5 = new HashSet<infoProtocol_K5>();
            this.InfoService5 = new HashSet<InfoService5>();
        }
    
        public int Code { get; set; }
        public string descript { get; set; }
        public Nullable<decimal> Id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
    
        public virtual Infouser Infouser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoProtocol_K5> infoProtocol_K5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoService5> InfoService5 { get; set; }
    }
}
