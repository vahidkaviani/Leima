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
    
    public partial class InfoSemat
    {
        public int Code { get; set; }
        public string descriptSemat { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string Date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<bool> @checked { get; set; }
    
        public virtual Infouser Infouser { get; set; }
    }
}
