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
    
    public partial class infoSection
    {
        public int CenterID { get; set; }
        public int ID_Software { get; set; }
        public decimal Code { get; set; }
        public string descript { get; set; }
        public Nullable<bool> fix { get; set; }
        public string NodePtr { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<bool> Checked { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}