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
    
    public partial class Message
    {
        public int id { get; set; }
        public string MessageText { get; set; }
        public Nullable<System.DateTime> MessageRegisterTime { get; set; }
        public Nullable<System.DateTime> MessageDeliverTime { get; set; }
        public Nullable<System.DateTime> MessageReadTime { get; set; }
        public Nullable<long> SenderTelegramID { get; set; }
        public Nullable<long> RecieverTelegramID { get; set; }
        public Nullable<bool> Readed { get; set; }
        public Nullable<short> Type { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
    }
}
