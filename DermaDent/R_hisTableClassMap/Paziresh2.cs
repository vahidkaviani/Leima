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
    
    public partial class Paziresh2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paziresh2()
        {
            this.Paziresh2_Detail1 = new HashSet<Paziresh2_Detail1>();
        }
    
        public decimal KindIDRel { get; set; }
        public int CenterID { get; set; }
        public string datevisit { get; set; }
        public string Date_Etebar { get; set; }
        public string date_Noskheh { get; set; }
        public string date_Nemoneh { get; set; }
        public Nullable<decimal> PageNo { get; set; }
        public Nullable<int> ID_Doctor { get; set; }
        public Nullable<decimal> ID_illness { get; set; }
        public Nullable<decimal> ID_Insur_illness { get; set; }
        public Nullable<decimal> ID_insur_Calculate { get; set; }
        public Nullable<decimal> ID_Niro { get; set; }
        public Nullable<decimal> ID_Nesbat { get; set; }
        public Nullable<decimal> ID_Status { get; set; }
        public Nullable<decimal> Mab_Service_Col { get; set; }
        public Nullable<decimal> Mab_illness_Col { get; set; }
        public Nullable<decimal> Mab_Org_Col { get; set; }
        public Nullable<decimal> Mab_ghabel_daryaft { get; set; }
        public Nullable<decimal> Mab_daryafti { get; set; }
        public Nullable<decimal> Mandeh { get; set; }
        public Nullable<decimal> Mab_takhfif_doctor_grp { get; set; }
        public Nullable<decimal> Mab_takhfif_Clinic_grp { get; set; }
        public Nullable<decimal> Mab_takhfif_doctor_frd { get; set; }
        public Nullable<decimal> Mab_takhfif_Clinic_frd { get; set; }
        public Nullable<decimal> Mab_yaraneh_illness_grp { get; set; }
        public Nullable<decimal> Mab_yaraneh_Additional_grp { get; set; }
        public Nullable<decimal> Mab_yaraneh_illness_frd { get; set; }
        public Nullable<decimal> Mab_yaraneh_Additional_frd { get; set; }
        public Nullable<int> Mab_round { get; set; }
        public Nullable<decimal> Mab_variance_illness_col { get; set; }
        public Nullable<decimal> Mab_from_saghf_col { get; set; }
        public string date_feedBack { get; set; }
        public Nullable<bool> Checked { get; set; }
        public Nullable<bool> flag_daryaft_hazineh { get; set; }
        public Nullable<decimal> id_paziresh { get; set; }
        public Nullable<byte> kind_paziresh { get; set; }
        public Nullable<decimal> Manager { get; set; }
        public Nullable<decimal> kind_daftar { get; set; }
        public Nullable<decimal> id_checkup { get; set; }
        public Nullable<decimal> id_paziresh_checkup { get; set; }
        public Nullable<bool> is_round { get; set; }
        public Nullable<int> groupid { get; set; }
        public Nullable<int> CountPrint { get; set; }
        public Nullable<decimal> ID_User { get; set; }
        public string Date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<decimal> from_saghf_illness_col { get; set; }
        public Nullable<decimal> from_saghf_additional_col { get; set; }
        public Nullable<decimal> mab_additional_col { get; set; }
        public string coderah { get; set; }
        public Nullable<decimal> id_smartCard { get; set; }
        public Nullable<byte> no_sample { get; set; }
        public Nullable<decimal> misID { get; set; }
    
        public virtual Grp_Master Grp_Master { get; set; }
        public virtual infoCenteral infoCenteral { get; set; }
        public virtual InfoSick InfoSick { get; set; }
        public virtual Infouser Infouser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paziresh2_Detail1> Paziresh2_Detail1 { get; set; }
    }
}
