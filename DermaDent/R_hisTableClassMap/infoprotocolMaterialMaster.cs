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
    
    public partial class infoprotocolMaterialMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public infoprotocolMaterialMaster()
        {
            this.infoprotocolMaterialDetails = new HashSet<infoprotocolMaterialDetail>();
        }
    
        public decimal ID { get; set; }
        public string Fromdate { get; set; }
        public string Todate { get; set; }
        public Nullable<decimal> id_service { get; set; }
        public Nullable<decimal> id_insur { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public Nullable<decimal> id_takhasos { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoprotocolMaterialDetail> infoprotocolMaterialDetails { get; set; }
        public virtual infoService infoService { get; set; }
        public virtual InfoTypespecial InfoTypespecial { get; set; }
        public virtual Infouser Infouser { get; set; }
        public virtual insur insur { get; set; }
    }
}