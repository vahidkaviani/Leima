using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Requests;
using Telegram.Bot.Requests.Abstractions;

using Telegram.Bot.Types.Enums;

namespace DSoftShopcheeBot
{
    public class ReceieveFileHandler
    {
        Telegram.Bot.TelegramBotClient Bot;

        public ReceieveFileHandler(TelegramBotClient bt)
        {
            Bot = bt;
        }

        public async void GetFileAndSave(string PathToSave, Telegram.Bot.Types.Message message)
        {
            string file = PathToSave;

            Telegram.Bot.Types.File DownloaddedFile =await Bot.GetFileAsync(message.Photo[message.Photo.Length - 1].FileId);
            File.Move(DownloaddedFile.FilePath, file);
        }

        public async void SaveAnyFile(string PathToSave, Telegram.Bot.Types.Message message)
        {
            string file = PathToSave;

           // var fileName = file.Split('\\').Last();

            //using (var fileStream = new FileStream(file, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
            {
                switch (message.Type)
                {
                    case MessageType.Photo:
                        //var v=await Bot.GetFileAsync(message.Photo[message.Photo.Length - 1].FileId);
                        //Telegram.Bot.Types.File fle = await Bot.GetFileAsync(message.Photo[message.Photo.Length - 1].FileId);
                        downloadFile(message, file);
                        //Console.WriteLine(fle.FileId);
                        //Console.WriteLine(fle.FilePath);
                        //Console.WriteLine(fle.FileSize);
                        //Console.WriteLine(v.FilePath);
                        //File.Move(v.FilePath, file);
                        break;

                    case MessageType.Video :
                        downloadFile(message, file);
                        //await Bot.GetFileAsync(message.Video.FileId, fileStream);
                        //  Telegram.Bot.Types.File fle= await Bot.GetFileAsync(message.Photo[message.Photo.Length - 1].FileId);
                        //Console.WriteLine(fle.FileId);
                        //Console.WriteLine(fle.FilePath);
                        //Console.WriteLine(fle.FileSize);

                        break;
                    case MessageType.Audio :
                        //await Bot.GetFileAsync(message.Audio.FileId, fileStream);
                        //File.Move((await Bot.GetFileAsync(message.Photo[message.Photo.Length - 1].FileId)).FilePath, file);
                        downloadFile(message, file);
                        break;
                    case MessageType.Voice :
                        //await Bot.GetFileAsync(message.Voice.FileId, fileStream);
                        //File.Move((await Bot.GetFileAsync(message.Photo[message.Photo.Length - 1].FileId)).FilePath, file);
                        downloadFile(message, file);
                        break;
                    case MessageType.Document :
                        //await Bot.GetFileAsync(message.Document.FileId, fileStream);
                        //File.Move((await Bot.GetFileAsync(message.Photo[message.Photo.Length - 1].FileId)).FilePath, file);
                        downloadFile(message, file);
                        break;
                    case MessageType.Unknown:
                        break;
                }
            }
        }
        public  async void downloadFile(Telegram.Bot.Types.Message message,string SaveToPath)
        {
            var file = await Bot.GetFileAsync(message.Photo.LastOrDefault()?.FileId);

            var filename = file.FileId + "." + file.FilePath.Split('.').Last();

            SaveToPath= Path.Combine(Path.GetDirectoryName(SaveToPath), filename);
            using (var saveImageStream = System.IO.File.Open(SaveToPath, FileMode.Create))
            {
                await Bot.DownloadFileAsync(file.FilePath, saveImageStream);
            }

        }
        private  async void DownloadFile(string fileId, string path)
        {
            try
            {
                var file = await Bot.GetFileAsync(fileId);

                //using (var saveImageStream = new System.IO.FileStream(path, FileMode.Create))
                //{
                //    await file.FileStream.CopyToAsync(saveImageStream);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error downloading: " + ex.Message);
            }
        }
    }
}
