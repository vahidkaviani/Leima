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
    
    public partial class InfoProtocolDetail5
    {
        public decimal ID { get; set; }
        public Nullable<decimal> RuleID_Master { get; set; }
        public Nullable<decimal> id_Service { get; set; }
        public Nullable<decimal> id_takhasos { get; set; }
        public Nullable<decimal> Mab_Dolati { get; set; }
        public Nullable<decimal> Mab_khososi { get; set; }
        public Nullable<decimal> Mab_v1 { get; set; }
        public Nullable<decimal> Mab_v2 { get; set; }
        public Nullable<bool> Kind_Other { get; set; }
        public Nullable<decimal> Mab_Other { get; set; }
        public Nullable<decimal> Mab_Additional { get; set; }
        public Nullable<decimal> Count_K { get; set; }
        public Nullable<decimal> Mab_K { get; set; }
        public Nullable<decimal> Per_Org1 { get; set; }
        public Nullable<byte> Kind_Org1 { get; set; }
        public Nullable<decimal> Per_Org2 { get; set; }
        public Nullable<byte> Kind_Org2 { get; set; }
        public string SingOrg { get; set; }
        public Nullable<decimal> Per_illness1 { get; set; }
        public Nullable<byte> Kind_illness1 { get; set; }
        public Nullable<decimal> Per_illness2 { get; set; }
        public Nullable<byte> Kind_illness2 { get; set; }
        public string signillness { get; set; }
        public Nullable<byte> send_mab_khales_illness { get; set; }
        public Nullable<bool> SendToInsur { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_edit { get; set; }
        public string time_edit { get; set; }
        public Nullable<decimal> Mab_Dolati_Smartcard { get; set; }
        public Nullable<decimal> Mab_khososi_Smartcard { get; set; }
        public Nullable<decimal> Mab_v1_Smartcard { get; set; }
        public Nullable<decimal> Mab_v2_Smartcard { get; set; }
        public Nullable<decimal> Per_Org1_Smartcard { get; set; }
        public Nullable<byte> Kind_Org1_Smartcard { get; set; }
        public Nullable<decimal> Per_Org2_Smartcard { get; set; }
        public Nullable<byte> Kind_Org2_Smartcard { get; set; }
        public string SingOrg_Smartcard { get; set; }
        public Nullable<decimal> Per_illness1_Smartcard { get; set; }
        public Nullable<byte> Kind_illness1_Smartcard { get; set; }
        public Nullable<decimal> Per_illness2_Smartcard { get; set; }
        public Nullable<byte> Kind_illness2_Smartcard { get; set; }
        public string signillness_Smartcard { get; set; }
        public Nullable<decimal> id_education_Smartcard { get; set; }
        public Nullable<decimal> id_Degree_Smartcard { get; set; }
    
        public virtual InfoProtocolMaster5 InfoProtocolMaster5 { get; set; }
        public virtual InfoService5 InfoService5 { get; set; }
        public virtual infotakhasos5 infotakhasos5 { get; set; }
    }
}
