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
    
    public partial class Software
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Software()
        {
            this.InfoCompanyDetail1 = new HashSet<InfoCompanyDetail1>();
        }
    
        public int ID { get; set; }
        public string descript { get; set; }
        public string date_edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<int> id_user { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoCompanyDetail1> InfoCompanyDetail1 { get; set; }
    }
}
