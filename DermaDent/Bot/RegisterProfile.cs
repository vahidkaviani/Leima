using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace DSoftShopcheeBot
{
    class RegisterProfile
    {
        TelegramBotClient bot;
        SQLServerTH dbt;
        public RegisterProfile(TelegramBotClient Robot)
        {
            bot = Robot;
            dbt = new SQLServerTH();
        }
        string ReturnButtonText = "باز گشت به منوی اصلی";
        /*Finished*/
        // 0 not finished complete
        // 1 Finished successfully
        // 2 Revised
        /*state*/
        // 1 user just registered
        // 2 user signed with
        public async void Manage(Message message, state s)
        {

            stateTask st = dbt.GetStateTask(s.current);
            if (message.Text == ReturnButtonText)
            {
                await bot.SendTextMessageAsync(message.Chat.Id, "لغو");
                dbt.UpdateUserCommandState(message.From.Id,11, st.SateID, message.Text, 1);
                SendKeyboard.SendKeyboardTo(bot, message, 1, true);
                return;
            }
            switch (s.current)
            {
                case 12://the incomming message is First Name
                    new DatabaseManager().SaveData(string.Format("UPDATE {0} SET  {1}={2} WHERE ({3}={4})AND({5}={6})",
                                                                        "UserProfile", "Finished", "999", "TelegramAssignedID", message.From.Id, "Finished", "0"));    //Incomplete Register
                    new DatabaseManager().SaveData(string.Format("UPDATE {0} SET  {1}={2} WHERE ({3}={4})AND({5}={6})",
                                                                        "UserProfile", "Finished", "2", "TelegramAssignedID", message.From.Id, "Finished", "1"));      //Override user profile

                    new DatabaseManager().SaveData(string.Format("INSERT INTO {0} ({1},{2},{3},{4},{5},{6},{7}) VALUES (N'{8}',N'{9}',N'{10}','{11}','{12}','{13}','{14}')", "UserProfile", "UserFirstName", "TelegramFirstName", "TelegramLastName", "TelegramAssignedID", "UserTelegramID", "State", "Finished",
                                                                                                                message.Text, message.From.FirstName, message.From.LastName, message.From.Id.ToString(), message.From.Username, "1", "0"));
                    dbt.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 3);
                    await bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);

                    break;

                case 13://the incomming message is Last Name
                    dbt.CreateOrCompleteField("UserProfile", "UserLastName", "TelegramAssignedID", message.From.Id.ToString(), message.Text, "Finished", "0");
                    dbt.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 3);
                    await bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                    break;

                case 14://the incomming message is phone no
                    dbt.CreateOrCompleteField("UserProfile", "MobileNo", "TelegramAssignedID", message.From.Id.ToString(), message.Text, "Finished", "0");
                   // dbt.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 3);
                    //await bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);

                    dbt.CreateOrCompleteField("UserProfile", "Finished", "TelegramAssignedID", message.From.Id.ToString(), "1", "Finished", "0");
                        dbt.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 1);
                        await bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                        SendKeyboard.SendKeyboardTo(bot, message, 1, true);

                    break;

                //case 15://the incomming message is Address
                //    dbt.CreateOrCompleteField("UserProfile", "Address", "TelegramAssignedID", message.From.Id.ToString(), message.Text, "Finished", "0");
                //    dbt.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 3);
                //    await bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                //    break;
 

                //case 22://the incomming message is reagent mobile or first/last name
                //    dbt.CreateOrCompleteField("UserProfile", "Reagent", "TelegramAssignedID", message.From.Id.ToString(), message.Text, "Finished", "0");
                //    dbt.CreateOrCompleteField("UserProfile", "Finished", "TelegramAssignedID", message.From.Id.ToString(),"1", "Finished", "0");
                //    dbt.UpdateUserCommandState(message.From.Id, st.NextState, st.SateID, message.Text, 1);
                //    await bot.SendTextMessageAsync(message.Chat.Id, st.NextQuestion);
                //    SendKeyboard.SendKeyboardTo(bot, message, 1, true);
                //    break;
                default:
                    return;
            }
        }
    }
}
