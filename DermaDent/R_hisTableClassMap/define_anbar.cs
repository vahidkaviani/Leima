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
    
    public partial class define_anbar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public define_anbar()
        {
            this.RequestGoodMasters = new HashSet<RequestGoodMaster>();
            this.RequestGoodMasters1 = new HashSet<RequestGoodMaster>();
        }
    
        public decimal kindid { get; set; }
        public string descript { get; set; }
        public Nullable<bool> @default { get; set; }
        public Nullable<decimal> codemanual { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<bool> @checked { get; set; }
        public Nullable<int> centerid { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestGoodMaster> RequestGoodMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestGoodMaster> RequestGoodMasters1 { get; set; }
    }
}
