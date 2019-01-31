using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace DSoftShopcheeBot
{
    class DashBoard : PageHandler
    {
        const string ReturnButtonText = "بازگشت به منوی اصلی";
        const string unreadMessage = "پیام ها";
        const string NotifiCations = "اطلاعیه";
        const string SendTicket = "ارسال پیام";
        const string PersonalInfo = "مشخصات من";
        const string PatientFileDocument = "مدارک بیمار";
        public DashBoard(TelegramBotClient Bot) : base(Bot)
        {
        }

        public async void Handle(Message message, state s)
        {
            stateTask st = Db.GetStateTask(s.current);
            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                if (message.Text.Contains(ReturnButtonText))
                {
                    Db.UpdateUserCommandState(message.From.Id, 11, st.SateID, message.Text, 1);
                    SendKeyboard.SendKeyboardTo(bt, message, 1, true);
                    return;
                }
            switch (message.Text)
            {
                case unreadMessage:
                    var result=Db.GetUnreadMessage(message.From.Id);
                    for (int i = 0; i < result.Count; i++)
                    {
                        await bt.SendTextMessageAsync(message.Chat.Id, result[i]);
                    }
                    if(result.Count<1)
                        await bt.SendTextMessageAsync(message.Chat.Id, "شما پیام ناخوانده ندارید");
                    break;
                case NotifiCations:
                    await bt.SendTextMessageAsync(message.Chat.Id, "اطلاعیه جدیدی ثبت نشده است");
                    break;
                case SendTicket:
                    //if(message.From.Id== 79532949)
                    //    await bt.SendTextMessageAsync(119549458, );
                    break;
                case PersonalInfo:
                    break;
            }
            if (message.Text.StartsWith(PatientFileDocument))
            {
                SendKeyboard.SendInlineFloatKeyBoard(bt, message, 1);
                //new SQLServerTH().GetUserRealName()
            }
        }
    }
}
