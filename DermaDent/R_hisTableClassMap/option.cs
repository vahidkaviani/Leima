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
    
    public partial class option
    {
        public decimal idauto { get; set; }
        public int CenterID { get; set; }
        public string title { get; set; }
        public string footer { get; set; }
        public byte[] arm { get; set; }
        public string title_Noskheh { get; set; }
        public string footer_Noskheh { get; set; }
        public string msg_tabrik { get; set; }
        public string msg_General { get; set; }
        public string msg_other { get; set; }
        public string N1 { get; set; }
        public string N2 { get; set; }
        public string N3 { get; set; }
        public string N4 { get; set; }
        public string N5 { get; set; }
        public string N6 { get; set; }
        public string N7 { get; set; }
        public string N8 { get; set; }
        public string N9 { get; set; }
        public string N10 { get; set; }
        public string N11 { get; set; }
        public byte[] P1 { get; set; }
        public byte[] P2 { get; set; }
        public byte[] P3 { get; set; }
        public byte[] P4 { get; set; }
        public byte[] P5 { get; set; }
        public byte[] P6 { get; set; }
        public byte[] P7 { get; set; }
        public byte[] P8 { get; set; }
        public byte[] P9 { get; set; }
        public byte[] P10 { get; set; }
        public byte[] P11 { get; set; }
        public Nullable<bool> StartupBackup { get; set; }
        public Nullable<bool> ExitBackup { get; set; }
        public Nullable<bool> S1 { get; set; }
        public Nullable<bool> S2 { get; set; }
        public Nullable<bool> S3 { get; set; }
        public Nullable<bool> S4 { get; set; }
        public Nullable<bool> Print_hazineh { get; set; }
        public Nullable<bool> Print_Paziresh { get; set; }
        public Nullable<int> Radif_Counter { get; set; }
        public Nullable<decimal> id_user { get; set; }
        public string arzesh_col { get; set; }
        public string IDCureCenter { get; set; }
        public string date_Edit { get; set; }
        public string Time_Edit { get; set; }
        public Nullable<bool> Sheet3 { get; set; }
        public Nullable<int> RoundMab { get; set; }
        public string VahedIDSend { get; set; }
        public Nullable<bool> compulsory { get; set; }
        public Nullable<bool> PageNocompulsory { get; set; }
        public Nullable<bool> ControlCodeSend { get; set; }
        public Nullable<bool> Controldental { get; set; }
        public Nullable<bool> ControlServicePaziresh { get; set; }
        public Nullable<bool> CashAfterPaziresh { get; set; }
        public Nullable<int> UserAccess { get; set; }
        public Nullable<bool> illnessCheck { get; set; }
        public Nullable<bool> ReminderAllUserAccess { get; set; }
        public Nullable<bool> AlarmReminders { get; set; }
        public Nullable<bool> EditDelete_CurrentMonth { get; set; }
        public Nullable<short> EditDelete_To_N_Roz { get; set; }
        public Nullable<bool> EditDelete_CurrentMonth2 { get; set; }
        public string NameNiro { get; set; }
        public string Path_PrintFile_FastReport { get; set; }
        public Nullable<int> ID_Software { get; set; }
        public Nullable<byte> CenterDegree { get; set; }
        public string version { get; set; }
        public Nullable<bool> recno_salaneh { get; set; }
        public Nullable<byte> updateProgress { get; set; }
        public string PortalRozaneh { get; set; }
        public string versionHis2 { get; set; }
        public Nullable<bool> ConfilitDoctorInCashForResid { get; set; }
        public Nullable<bool> DeleteDateCash_Today_Or_PriorDay { get; set; }
        public Nullable<int> CenterID_CRM { get; set; }
        public Nullable<decimal> ID_Type_Center { get; set; }
        public Nullable<byte> zarib_to_service { get; set; }
        public Nullable<byte> zarib_to_lab { get; set; }
        public Nullable<byte> zarib_to_material { get; set; }
    
        public virtual infoCenteral infoCenteral { get; set; }
    }
}
