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
    
    public partial class ProtocolRadio
    {
        public int ID { get; set; }
        public int RuleID { get; set; }
        public Nullable<int> Code { get; set; }
        public int RowID { get; set; }
        public int id_insur { get; set; }
        public string D_Run { get; set; }
        public string D_Expire { get; set; }
        public Nullable<decimal> Per_Org1 { get; set; }
        public Nullable<int> KindOrg1 { get; set; }
        public string SingOrg1 { get; set; }
        public Nullable<decimal> Per_Org2 { get; set; }
        public Nullable<int> KindOrg2 { get; set; }
        public string SingOrg2 { get; set; }
        public Nullable<int> KindOrg3 { get; set; }
        public Nullable<decimal> Per_illness1 { get; set; }
        public Nullable<int> Kindillness1 { get; set; }
        public string Singillness1 { get; set; }
        public Nullable<decimal> Per_illness2 { get; set; }
        public Nullable<int> Kindillness2 { get; set; }
        public string Singillness2 { get; set; }
        public Nullable<int> Kindillness3 { get; set; }
        public Nullable<int> id_user { get; set; }
        public string date_Edit { get; set; }
        public string time_Edit { get; set; }
        public string FileNameSend { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> per_illness3 { get; set; }
        public Nullable<decimal> per_illness4 { get; set; }
        public Nullable<int> Kindillness4 { get; set; }
        public string Code_Send_Bimeh { get; set; }
        public Nullable<byte> send_mab_khales_illness { get; set; }
        public Nullable<byte> send_mab_khales_org { get; set; }
        public string code_kind_markaz { get; set; }
    
        public virtual InfoRadio InfoRadio { get; set; }
    }
}
