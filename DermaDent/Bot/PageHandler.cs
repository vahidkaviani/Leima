using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace DSoftShopcheeBot
{
    public  class PageHandler
    {
        public static string ReturnButtonText = "بازگشت به منوی اصلی";
        public static string SkipState = "ادامه";

        private SQLServerTH db;
        TelegramBotClient bot;


        internal SQLServerTH Db
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }
        internal TelegramBotClient bt
        {
            get
            {
                return bot;
            }

            set
            {
                bot = value;
            }
        }
        public PageHandler(TelegramBotClient Bot)
        {
            bot = Bot;
            db = new SQLServerTH();
        }
    }
}
