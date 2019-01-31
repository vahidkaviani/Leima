using DSoftShopcheeBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace DermaDent.Bot
{
    class TransmitPatientDocument : PageHandler
    {
        public TransmitPatientDocument(TelegramBotClient Bot) : base(Bot)
        {
        }

        public async void Manage(Message message, state s)
        {
            stateTask st = Db.GetStateTask(s.current);
            if (message.Text == ReturnButtonText)
            {
                await bt.SendTextMessageAsync(message.Chat.Id, "لغو");
                Db.UpdateUserCommandState(message.From.Id, 11, st.SateID, message.Text, 1);
                SendKeyboard.SendKeyboardTo(bt, message, 1, true);
                return;
            }
            switch (s.current)
            {
                case 28:    // the incomming message is Patient File id or Name
                    if (message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                        await bt.SendTextMessageAsync(message.Chat.Id, "لطفا شماره پرونده را صحیح وارد کنید");

                    if (!message.Text.Contains(','))
                    {
                        SendKeyboard.SendKeyboardTo(bt, message, 3, true);
                        try
                        {
                            int count = int.Parse(message.Text);
                            if (count < 10000 || count > 100000000)
                            {
                                await bt.SendTextMessageAsync(message.Chat.Id, "لطفا شماره پرونده را صحیح وارد کنید");
                                return;
                            }
                        }
                        catch
                        {
                            var keyboard = SQLServerTH.GetPatientAsKeyboard(message.Text);
                            KeyboardButton[][] keys = new KeyboardButton[keyboard.Count + 1][];
                            if (keyboard.Count > 0)
                            {
                                for (int i = 0; i < keyboard.Count; i++)
                                {
                                    keys[i] = new KeyboardButton[1];
                                    keys[i][0] = keyboard[i];
                              }
                                KeyboardButton btn = new KeyboardButton("بازگشت به منوی اصلی");
                                keys[keyboard.Count] = new KeyboardButton[1];
                                keys[keyboard.Count][0] = btn;
                                ReplyKeyboardMarkup markup = new ReplyKeyboardMarkup(keys, true);
                                await bt.SendTextMessageAsync(message.From.Id, "انتخاب کنید", replyMarkup: markup);
                            }
                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            //we have ID
                            string Pid = message.Text.Split(',')[0];

                            //new DatabaseManager().SaveData(string.Format("UPDATE {0} SET  {1}={2} WHERE ({3}={4})AND({5}={6})",
                            //"PatientDocument", "Finished", "999", "SenderTelegramID", message.From.Id, "Finished", "0")); // cancel invalid links
                            //new DatabaseManager().SaveData(string.Format("INSERT INTO {0} ({1},{2},{3},{7}) VALUES ('{4}','{5}','{6}','{8}')", "PatientDocument", "Finished", "PatientID", "SenderTelegramID", "0", Pid, message.From.Id, "RegisterDateTime", DateTime.Now));


                            Db.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 9);

                        }
                        catch
                        {
                        }
                    }
                    break;
            }
        }

    }
}
