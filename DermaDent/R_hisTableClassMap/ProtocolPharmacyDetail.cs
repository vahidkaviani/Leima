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
    
    public partial class ProtocolPharmacyDetail
    {
        public decimal KindID { get; set; }
        public int RowID { get; set; }
        public int Code { get; set; }
        public double Per_illness { get; set; }
        public double Per_Org { get; set; }
        public Nullable<double> CountDrugID { get; set; }
        public Nullable<decimal> Max_Mab_Bimeh { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<byte> FlagDelEdit { get; set; }
        public Nullable<decimal> FK_magic_kindid { get; set; }
    
        public virtual ProtocolPharmacyMaster ProtocolPharmacyMaster { get; set; }
    }
}
