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
    
    public partial class InfoProtocolMaster_labrator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoProtocolMaster_labrator()
        {
            this.InfoProtocolDetail_labrator = new HashSet<InfoProtocolDetail_labrator>();
        }
    
        public decimal Rule_id { get; set; }
        public Nullable<decimal> id_lab { get; set; }
        public string from_date { get; set; }
        public string to_date { get; set; }
        public Nullable<int> centerid { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoProtocolDetail_labrator> InfoProtocolDetail_labrator { get; set; }
    }
}
