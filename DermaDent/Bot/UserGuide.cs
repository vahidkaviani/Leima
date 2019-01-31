using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace DSoftShopcheeBot
{
    class UserGuide :PageHandler
    {
        string ReturnButtonText = "بازگشت به منوی اصلی";
        const string PreviousPage = "صفحه قبل";
        const string NextPage = "صفحه بعد";
        public UserGuide(TelegramBotClient Bot) :base(Bot)
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
                case NextPage:
                    var result = Db.GetUnreadMessage(message.From.Id);
                    for (int i = 0; i < result.Count; i++)
                    {
                        await bt.SendTextMessageAsync(message.Chat.Id, result[i]);
                    }
                    if (result.Count < 1)
                        await bt.SendTextMessageAsync(message.Chat.Id, "throw not implemented exeption");
                    break;
                case PreviousPage:
                    await bt.SendTextMessageAsync(message.Chat.Id, "Not Implemented yet");
                    break;
                default:

                    break;
            }
        }
    }
}
