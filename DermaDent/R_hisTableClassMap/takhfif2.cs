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
    
    public partial class takhfif2
    {
        public int RuleID { get; set; }
        public int SectionID { get; set; }
        public int ID_Software { get; set; }
        public int RowID { get; set; }
        public int Code { get; set; }
        public string HeaderRule { get; set; }
        public Nullable<byte> Group12 { get; set; }
        public Nullable<int> id_illness { get; set; }
        public Nullable<int> id_visit { get; set; }
        public string date_visit { get; set; }
        public Nullable<double> Per_Clinic { get; set; }
        public Nullable<decimal> Mab_Clinic { get; set; }
        public Nullable<double> Per_doctor { get; set; }
        public Nullable<decimal> Mab_doctor { get; set; }
        public Nullable<int> id_insur { get; set; }
        public Nullable<int> id_niro { get; set; }
        public Nullable<int> id_status { get; set; }
        public Nullable<int> id_Nesbat { get; set; }
        public string D_Run { get; set; }
        public string D_Expire { get; set; }
        public Nullable<int> id_user { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<byte> Cancel_Flag { get; set; }
        public Nullable<int> Idauto { get; set; }
        public Nullable<int> CenterID { get; set; }
        public string date_delete { get; set; }
        public Nullable<int> id_userDelete { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> KindidRel { get; set; }
        public Nullable<bool> freeTakhfif { get; set; }
        public Nullable<int> code_caus_takhfif { get; set; }
        public Nullable<decimal> mab_clinic_khedmat { get; set; }
        public Nullable<decimal> mab_clinic_material { get; set; }
        public Nullable<decimal> mab_doctor_khedmat { get; set; }
        public Nullable<decimal> mab_doctor_material { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}
