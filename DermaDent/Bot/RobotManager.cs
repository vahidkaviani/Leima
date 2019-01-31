using DermaDent.Bot;
using DSoftShopcheeBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace DSDentAssist
{
    public class RobotManager
    {
        public readonly TelegramBotClient Bot;

        MainPage homePage;
        ReceieveFileHandler rfh;
        SQLServerTH ssth;
        RegisterProfile rp;
        DashBoard dshbrd;
        UserGuide ug;
        UserDetailManager udm;
        ManageFileDocument mfd;
        TransmitPatientDocument tpd;
        ChargeManager cm;
        public RobotManager(string Token)
        {
            Bot = new TelegramBotClient(Token);
            SetUpNewTelegramBot();

            ssth = new SQLServerTH();
            homePage = new MainPage(Bot);
            rfh = new ReceieveFileHandler(Bot);
            rp = new RegisterProfile(Bot);
            dshbrd = new DashBoard(Bot);
            ug = new UserGuide(Bot);
            udm = new UserDetailManager(Bot);
            mfd = new ManageFileDocument(Bot);
            tpd = new TransmitPatientDocument(Bot);
            cm = new ChargeManager(Bot);
        }

        void SetUpNewTelegramBot()
        {
            Bot.OnCallbackQuery += BotOnCallbackQueryReceived;
            Bot.OnMessage += BotOnMessageReceived;
            Bot.OnMessageEdited += BotOnMessageReceived;
            Bot.OnInlineQuery += BotOnInlineQueryReceived;
            Bot.OnInlineResultChosen += BotOnChosenInlineResultReceived;
            Bot.OnReceiveError += BotOnReceiveError;
            Bot.OnInlineResultChosen += Bot_OnInlineResultChosen;
           //var me = Bot.GetMeAsync().Result;

            Bot.StartReceiving();

        }

        private void Bot_OnInlineResultChosen(object sender, ChosenInlineResultEventArgs e)
        {
            
        }

        private async void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            // bool result = await Bot.AnswerCallbackQueryAsync("CallBackQueryID", "Text", true, null, new System.Threading.CancellationToken());// callbackQueryEventArgs.CallbackQuery.Id,
            Console.WriteLine(callbackQueryEventArgs.CallbackQuery.Data);
        }
        
        bool TimedOut(DateTime dt)
        {
            if ((DateTime.Now - dt).TotalSeconds > 3600)
                return true;
            return false;
        }

        private async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {
            try
            {
                var message = messageEventArgs.Message;

                await Bot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

                Console.WriteLine(message.From.FirstName + " " + message.From.LastName + "->" + message.From.Id + "->" + message.From.Username + "->" + message.Text);
                await Bot.SendTextMessageAsync(119549458, message.From.FirstName + " " + message.From.LastName + "->" + message.From.Id + "->" + message.From.Username + "->" + message.Text);
                if (message.Type == MessageType.Venue);

                if (message == null) return;

                state lastState = new SQLServerTH().GetLastState(message.From.Id);

                if (lastState.Page == 0)
                {
                    homePage.HandleHomeActions(message, lastState);
                }
                if (lastState.Page == 3)
                {
                    rp.Manage(message, lastState);
                }
                else if (lastState.Page == 2)
                {
                    // rbo.HandleBuy(message, lastState);
                }
                else if (lastState.Page == -1)
                {
                    homePage.BotFirstTime(message);
                    ssth.InitUserStateAtHome(message.From.Id);
                }
                else if (lastState.Page == 1)
                {
                    homePage.HandleHomeActions(message, lastState);
                }
                else if (lastState.Page == 4)
                {
                    //  rpr.Handle(message, lastState);
                }
                else if (lastState.Page == 5)
                {
                    //  fr.Handle(message, lastState);
                }
                else if (lastState.Page == 6)
                {
                    dshbrd.Handle(message, lastState);
                }
                else if (lastState.Page == 7)
                {
                    udm.Handle(message, lastState);
                }

                else if (lastState.Page == 9)
                {
                    mfd.Manage(message, lastState);
                }
                else if (lastState.Page == 10)
                {
                    tpd.Manage(message, lastState);
                }
                else if (lastState.Page == 11)
                {
                    cm.Handle(message, lastState);
                }
            }
            catch { }
        }
        private async void BotOnInlineQueryReceived(object sender, InlineQueryEventArgs inlineQueryEventArgs)
        {
            Console.WriteLine($"BotOnInlineQueryReceived");
        }


        private void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine($"BotOnReceiveError");
        }

        private void BotOnChosenInlineResultReceived(object sender, ChosenInlineResultEventArgs chosenInlineResultEventArgs)
        {
            Console.WriteLine($"Received choosen inline result: {chosenInlineResultEventArgs.ChosenInlineResult.ResultId}");
        }

        public async void SendMessage(int id,string messageText)
        {
            await Bot.SendTextMessageAsync(id, messageText);
        }
    }
}
