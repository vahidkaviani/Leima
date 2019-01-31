using DSoftShopcheeBot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace DermaDent.Bot
{
    class ChargeManager : PageHandler
    {
        public ChargeManager(TelegramBotClient Bot) : base(Bot)
        {

        }
        public async void Handle(Message message, state s)
        {
            stateTask st = Db.GetStateTask(s.current);
            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (message.Text.Contains(ReturnButtonText))
                {
                    Db.UpdateUserCommandState(message.From.Id, 11, st.SateID, message.Text, 1);
                    SendKeyboard.SendKeyboardTo(bt, message, 1, true);
                    return;
                }
                else
                {
                    System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                    int year=pc.GetYear(DateTime.Now);
                    
                    for (int i = 1; i <=12; i++)
                    {
                        if (message.Text.Contains(PersianDateTime.Months[i]))
                        {
                            string from = string.Format("{0}/{1:D2}/01", year, i);
                            string to = string.Format("{0}/{1:D2}/31", year, i);
                            var TodayAccountWorkResult = Db.GetTodayTransactions(TelegramID: message.From.Id, fromDate: from, ToDate: to);
                            if (TodayAccountWorkResult.Count < 2)
                            {
                                bt.SendTextMessageAsync(message.From.Id, "با عرض پوزش برای تاریخ انتخابی شما گزارش کارکردی ثبت نشده");
                                return;
                            }
                            FormatPrinter fp = new FormatPrinter();

                            fp.drName = TodayAccountWorkResult[0].drName;

                            fp.fromDate = from;// PersianDateTime.GetPersianDate(DateTime.Now.AddDays(-70));
                            fp.ToDate = to;// PersianDateTime.GetPersianDate(DateTime.Now);
                            fp.Redraw();
                            fp.DrawTableContent(TodayAccountWorkResult);
                            
                            SendSecretPic(message.From.Id, fp.bmp);
                            return;
                        }
                    }
                }
            }
                
        //switch (message.Text)
        //{
        //    case unreadMessage:
        //        var result = Db.GetUnreadMessage(message.From.Id);
        //        for (int i = 0; i < result.Count; i++)
        //        {
        //            await bt.SendTextMessageAsync(message.Chat.Id, result[i]);
        //        }
        //        if (result.Count < 1)
        //            await bt.SendTextMessageAsync(message.Chat.Id,"");
        //        break;
        //    case NotifiCations:
        //        await bt.SendTextMessageAsync(message.Chat.Id, "");
        //        break;
        //    case SendTicket:
        //        //if(message.From.Id== 79532949)
        //        //    await bt.SendTextMessageAsync(119549458, );
        //        break;
        //    case PersonalInfo:
        //        break;
        //}
    }
        public async void SendSecretPic(int msg, Bitmap img)
        {
            ScreenCapture sc = new ScreenCapture();
            
            Bitmap bmp = img;
            var res = ImageToByte2(bmp);

            Stream s = new MemoryStream(res);
            Telegram.Bot.Types.InputFiles.InputOnlineFile fts = new Telegram.Bot.Types.InputFiles.InputOnlineFile(s, "invoice.jpg");
            await bt.SendDocumentAsync(msg, fts);
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }

}
