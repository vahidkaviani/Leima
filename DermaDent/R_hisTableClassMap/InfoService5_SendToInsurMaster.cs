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
    
    public partial class InfoService5_SendToInsurMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoService5_SendToInsurMaster()
        {
            this.InfoService5_SendToInsurDetail = new HashSet<InfoService5_SendToInsurDetail>();
        }
    
        public decimal ID { get; set; }
        public Nullable<decimal> id_insur { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string Date_Edit { get; set; }
        public string Time_Edit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoService5_SendToInsurDetail> InfoService5_SendToInsurDetail { get; set; }
        public virtual Infouser Infouser { get; set; }
        public virtual insur insur { get; set; }
    }
}
