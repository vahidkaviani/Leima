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
    
    public partial class PatientFirstDetail_Records
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_PatientFirstMaster { get; set; }
        public Nullable<int> id_Records { get; set; }
        public string date_Records { get; set; }
        public string comment { get; set; }
        public string date_behbod { get; set; }
    
        public virtual infoRecord infoRecord { get; set; }
        public virtual PatientFirstMaster PatientFirstMaster { get; set; }
    }
}
