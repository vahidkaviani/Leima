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
    
    public partial class infotakhasos8
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public infotakhasos8()
        {
            this.infodoctor8 = new HashSet<infodoctor8>();
            this.InfoProtocolDetail8 = new HashSet<InfoProtocolDetail8>();
        }
    
        public decimal Code { get; set; }
        public Nullable<int> CenterID { get; set; }
        public string descript { get; set; }
        public Nullable<bool> Checked { get; set; }
        public Nullable<decimal> Id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<int> mis_code { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infodoctor8> infodoctor8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoProtocolDetail8> InfoProtocolDetail8 { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}