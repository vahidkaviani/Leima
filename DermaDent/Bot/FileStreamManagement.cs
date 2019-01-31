using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace DSoftShopcheeBot
{
    class FileStreamManagement
    {
        public int SaveImageToDB(Message message, string Path,TelegramBotClient Bot)
        {
            savePhotoFile(message, Path, Bot);
            return new SQLServerTH().SaveImage(message.Photo[message.Photo.Length - 1].FileId, Path, message.From.Id);
        }
        public void savePhotoFile(Message message,string Path,TelegramBotClient Bot)
        {
            ReceieveFileHandler rfh = new ReceieveFileHandler(Bot);
            if (message.Type == MessageType.Photo)
            {
                rfh.GetFileAndSave(Path + "\\" + message.Photo[message.Photo.Length - 1].FileId, message);
            }
        }
    }
}
