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
    
    public partial class QueueBakhsh
    {
        public decimal id { get; set; }
        public Nullable<int> CenterID { get; set; }
        public Nullable<decimal> id_Nobat { get; set; }
        public Nullable<decimal> DateNobat { get; set; }
        public Nullable<decimal> ID_do { get; set; }
        public Nullable<decimal> ID_Patient { get; set; }
        public Nullable<decimal> id_User { get; set; }
        public string D_Edit { get; set; }
        public string T_Edit { get; set; }
        public Nullable<bool> IsCalledQueue { get; set; }
        public string D_CalledQueue { get; set; }
        public string T_CalledQueue { get; set; }
        public Nullable<byte> IsAbsentQueue { get; set; }
        public string T_AbsentQueue { get; set; }
        public Nullable<int> FromNobat_Or_BedonVaghtGabli { get; set; }
        public string From_Time { get; set; }
        public string To_Time { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual Infouser Infouser { get; set; }
    }
}