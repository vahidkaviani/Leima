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
    
    public partial class infoRepresenter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public infoRepresenter()
        {
            this.visitings = new HashSet<visiting>();
        }
    
        public decimal code { get; set; }
        public string representer { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<bool> @checked { get; set; }
    
        public virtual Infouser Infouser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<visiting> visitings { get; set; }
    }
}