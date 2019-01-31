using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
//using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types.ReplyMarkups;

namespace DSoftShopcheeBot
{
    struct KeyBoard { }
    public class SendKeyboard
    {
        TelegramBotClient b;
        Message m;
        public SendKeyboard(TelegramBotClient Bot,Message message)
        {
            b = Bot;
        }

        public SendKeyboard(){}

        public async static void  SendKeyboardTo(TelegramBotClient bot, Message m,int KeyBoardID,bool _sendKeyBoardText=true)
        {

            List<List<KeyboardButton>> KB = new SQLServerTH().GetKeyBoardDetails(KeyBoardID);
            KeyboardButton[][] btns = new KeyboardButton[KB.Count][];
            for (int i = 0; i < KB.Count; i++)
            {
                btns[i] = KB[i].ToArray();
            }
            ReplyKeyboardMarkup KeyBoard = new ReplyKeyboardMarkup(btns, resizeKeyboard:true);
            string KBTextMessage = new SQLServerTH().GetKeyBoardText(KeyBoardID);
            if(!String.IsNullOrEmpty(KBTextMessage)&&_sendKeyBoardText)
            await bot.SendTextMessageAsync(m.Chat.Id, KBTextMessage, replyMarkup: KeyBoard);
            else
                await bot.SendTextMessageAsync(m.Chat.Id,"______________________", replyMarkup: KeyBoard);
        }

        public async static void SendInlineFloatKeyBoard(TelegramBotClient bot, Message m, int KeyBoardID, bool _sendKeyBoardText = true)
        {
            List<List<InlineKeyboardButton>> KB = new SQLServerTH().GetInlineKeyBoardDetails(KeyBoardID);
            InlineKeyboardButton[][] btns = new InlineKeyboardButton[KB.Count][];
            for (int i = 0; i < KB.Count; i++)
            {
                btns[i] = KB[i].ToArray();
            }
            Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup KeyBoard = new InlineKeyboardMarkup(btns);
            string KBTextMessage = new SQLServerTH().GetKeyBoardText(KeyBoardID);
            if (!String.IsNullOrEmpty(KBTextMessage) && _sendKeyBoardText)
                await bot.SendTextMessageAsync(m.Chat.Id, KBTextMessage, replyMarkup: KeyBoard);
            else
                await bot.SendTextMessageAsync(m.Chat.Id, "______________________", replyMarkup: KeyBoard);


        }
    }
}
