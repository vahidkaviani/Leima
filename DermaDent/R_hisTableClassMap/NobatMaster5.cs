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
    
    public partial class NobatMaster5
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NobatMaster5()
        {
            this.NobatDetail5 = new HashSet<NobatDetail5>();
        }
    
        public decimal ID { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> id_Section { get; set; }
        public Nullable<int> id_doctor { get; set; }
        public Nullable<decimal> dateNobat { get; set; }
        public Nullable<byte> dayNumber { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NobatDetail5> NobatDetail5 { get; set; }
    }
}
