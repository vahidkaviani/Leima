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
    
    public partial class OptionRadio
    {
        public decimal ID { get; set; }
        public Nullable<int> CenterID { get; set; }
        public string PathResultRadioRead { get; set; }
        public string PathResultRadioWrite { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual infoCenteral infoCenteral1 { get; set; }
    }
}