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
    
    public partial class SendBimehMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SendBimehMaster()
        {
            this.SendBimehDetails = new HashSet<SendBimehDetail>();
        }
    
        public int KindID { get; set; }
        public Nullable<decimal> id_insur { get; set; }
        public Nullable<decimal> Code1 { get; set; }
        public string CodeSend { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SendBimehDetail> SendBimehDetails { get; set; }
    }
}