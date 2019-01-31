using DermaDent.Document;
using DSoftShopcheeBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace DermaDent.Bot
{
    public class ManageFileDocument : DSoftShopcheeBot.PageHandler
    {
        public static string ReturnButtonText = "بازگشت به منوی اصلی";
        public static string SkipState = "ادامه";
        public ManageFileDocument(TelegramBotClient Bot) : base(Bot)
        {
            bt = Bot;
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
                case 28:    // the incomming message is Patient File id
                    if (message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                    {
                        await bt.SendTextMessageAsync(message.Chat.Id, "لطفا شماره پرونده را صحیح وارد کنید");
                        return;
                    }
                    if (!message.Text.Contains(','))
                    {
                       // SendKeyboard.SendKeyboardTo(bt, message, 3, true);
                        try
                        {
                            int count = int.Parse(message.Text);
                            if (count < 1 || count > 100000000)
                            {
                                await bt.SendTextMessageAsync(message.Chat.Id, "لطفا شماره پرونده را صحیح وارد کنید");
                                return;
                            }
                            else
                            {
                                new DatabaseManager().SaveData(string.Format("UPDATE {0} SET  {1}={2} WHERE ({3}={4})AND({5}={6})",
                                                                                        "PatientDocument", "Finished", "999", "SenderTelegramID", message.From.Id, "Finished", "0")); // cancel invalid links
                                new DatabaseManager().SaveData(string.Format("INSERT INTO {0} ({1},{2},{3},{7}) VALUES ('{4}','{5}','{6}','{8}')", "PatientDocument", "Finished", "PatientID", "SenderTelegramID", "0", message.Text, message.From.Id, "RegisterDateTime", DateTime.Now));


                                Db.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 9);

                                var result = Transaction.GetPatientList(FileID: message.Text);
                                if (result.Rows.Count > 0)
                                    await bt.SendTextMessageAsync(message.Chat.Id, string.Format("{0} {1} ", "شما در حال ثبت مدرک برای :", ((string)result.Rows[0]["FNameSick"]) + " " + ((string)result.Rows[0]["LNameSick"])));

                                await bt.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                            }

                        }
                        catch
                        {
                            // await bt.SendTextMessageAsync(message.Chat.Id, "لطفا شماره پرونده را به صورت عددی (انگلیسی) وارد کنید");
                            var keyboard = SQLServerTH.GetPatientAsKeyboard(message.Text);
                            KeyboardButton[][] keys = new KeyboardButton[keyboard.Count+1][];
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
                                ReplyKeyboardMarkup markup = new ReplyKeyboardMarkup(keys,true);
                                await bt.SendTextMessageAsync(message.From.Id, "انتخاب کنید", replyMarkup: markup);
                            }
                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            string Pid = message.Text.Split(',')[0];

                            new DatabaseManager().SaveData(string.Format("UPDATE {0} SET  {1}={2} WHERE ({3}={4})AND({5}={6})",
                                                                                    "PatientDocument", "Finished", "999", "SenderTelegramID", message.From.Id, "Finished", "0")); // cancel invalid links
                            new DatabaseManager().SaveData(string.Format("INSERT INTO {0} ({1},{2},{3},{7}) VALUES ('{4}','{5}','{6}','{8}')", "PatientDocument", "Finished", "PatientID", "SenderTelegramID", "0", Pid, message.From.Id, "RegisterDateTime", DateTime.Now));


                            Db.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 9);

                            var result = Transaction.GetPatientList(FileID: Pid);
                            if (result.Rows.Count > 0)
                                await bt.SendTextMessageAsync(message.Chat.Id, string.Format("{0} {1} ", "شما در حال ثبت مدرک برای :", ((string)result.Rows[0][0]) + " " + ((string)result.Rows[0][1])));

                            await bt.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                        }
                        catch
                        {
                        }
                    }
                    break;
                    //case 19://the incomming message is recipt subject
                //    if (message.Type != Telegram.Bot.Types.Enums.MessageType.TextMessage)
                //    {
                //        await bot.SendTextMessageAsync(message.Chat.Id, "لطفا توضیحات را به صورت نوشتاری و به فارسی وارد کنید");
                //        return;
                //    }
                //    if (message.Text.Length < 8)
                //    {
                //        await bot.SendTextMessageAsync(message.Chat.Id, "لطفا توضیحات بیشتری ارائه دهید");
                //        return;
                //    }
                //    //if (message.Text != "ادامه")
                //    db.CreateOrCompleteField("[Reciept]", "[Subject]", "Telegram_Id", message.From.Id.ToString(), message.Text, "Finished", "0");

                //    db.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 4);
                //    await bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                //    break;

                case 30://the incomming message is file

                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Audio ||
                       message.Type == Telegram.Bot.Types.Enums.MessageType.Photo ||
                       message.Type == Telegram.Bot.Types.Enums.MessageType.Video ||
                       message.Type == Telegram.Bot.Types.Enums.MessageType.Voice ||
                       message.Type == Telegram.Bot.Types.Enums.MessageType.Document )
                    {
                        string fileid="";
                        string fileName="";
                        switch (message.Type)
                        {
                            case Telegram.Bot.Types.Enums.MessageType.Audio:
                                fileid = message.Audio.FileId;
                                fileName = ".mp3";
                                break;
                            case Telegram.Bot.Types.Enums.MessageType.Voice:
                                fileid = message.Voice.FileId;
                                fileName = ".amr";
                                break;
                            case Telegram.Bot.Types.Enums.MessageType.Video:
                                fileid = message.Video.FileId;
                                fileName = ".mp4";
                                break;
                            case Telegram.Bot.Types.Enums.MessageType.Photo:
                                fileid = message.Photo[0].FileId;
                                fileName = ".jpg";
                                break;
                            case Telegram.Bot.Types.Enums.MessageType.Document:
                                fileid = message.Document.FileId;
                                fileName = message.Document.FileName;
                                break;
                        }
                        DocumentManager dm = new DocumentManager(DermaDent.Properties.Settings.Default.PatientDocumentSavePath, s.answer.Split(',')[0]);
                        string saveToPat = System.IO.Path.Combine(dm.UserPath, fileid + fileName);
                        new ReceieveFileHandler(bt).SaveAnyFile(saveToPat, message);

                        Db.CreateOrCompleteField("[PatientDocument]", "[FileName]", "SenderTelegramID", message.From.Id.ToString(), fileid+fileName, "Finished", "0");

                        Db.CreateOrCompleteField("[PatientDocument]", "Finished", "SenderTelegramID", message.From.Id.ToString(), "1", "Finished", "0");//Finished
                        Db.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 1);
                        await bt.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);

                        Db.UpdateUserCommandState(message.From.Id, 11, st.SateID, message.Text, 1);
                        SendKeyboard.SendKeyboardTo(bt, message, 1, true);
                    }
                    else
                    {
                        await bt.SendTextMessageAsync(message.Chat.Id, "لطفا فایل ارسال فرمایید");
                    }
                    break;

                default:
                    return;
            }
        }
    
    }
}
