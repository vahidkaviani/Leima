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
    
    public partial class infoProtocol_Mokamel_Detail4
    {
        public decimal ID { get; set; }
        public decimal RuleIDRel { get; set; }
        public int id_Service { get; set; }
        public Nullable<decimal> Per_From_illness { get; set; }
        public Nullable<decimal> Mab_up_illness { get; set; }
        public Nullable<decimal> Per_From_Material { get; set; }
        public Nullable<decimal> Mab_up_Material { get; set; }
        public Nullable<decimal> Per_From_Lab { get; set; }
        public Nullable<decimal> Mab_up_Lab { get; set; }
        public Nullable<decimal> Per_From_Additional { get; set; }
        public Nullable<decimal> Mab_up_Additional { get; set; }
        public Nullable<bool> Mab_Additional_From_insur { get; set; }
        public Nullable<decimal> id_insur1 { get; set; }
        public Nullable<decimal> id_insur2 { get; set; }
        public Nullable<bool> free_ehtesab { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<byte> kind_illness1 { get; set; }
        public string signillness { get; set; }
        public Nullable<byte> kind_illness2 { get; set; }
        public Nullable<byte> kind_additional1 { get; set; }
        public string signadditional { get; set; }
        public Nullable<byte> kind_additional2 { get; set; }
    
        public virtual infoProtocol_Mokamel_Master4 infoProtocol_Mokamel_Master4 { get; set; }
        public virtual InfoRadio InfoRadio { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}
