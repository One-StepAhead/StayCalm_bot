using Castle.Core.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StayCalmBot.Models.Entities;
using Telegram.Bot.Types;

namespace StayCalmBot.Controllers
{
    public class DatabaseManager
    {
        
        public static Client CurrentUser { get; set; }

        public static Boolean UserExist(long chatId, string userName)
        {
            
            string ChatID = Convert.ToString(chatId);

            Client existingUser = MainDB.Instance.Clients.FirstOrDefault(x => x.ChatId == ChatID &&
                                                                           x.UserName == userName);

            if (existingUser != null)
            {
                CurrentUser = existingUser;
                return true;
            }
            else
                return false;
        }

        public static void AddUser(string ChatID, string UserName, string FirstName, int StressLevel)
        {
            Client newUser = new()
            {
                ChatId = ChatID,
                UserName = UserName,
                FirstName = FirstName
            };
            MainDB.Instance.Clients.Add(newUser);
            MainDB.Instance.SaveChanges();
        }

        public static void EditUserStressLevel(User user, int newStressLevel)
        {
            //if (user != null)
            //{
            //    user.StressLevelId = newStressLevel;
            //    MainDB.Instance.SaveChanges();
            //}
        }

        public static void AddCompletedLevel(User user, int stressLevelId, int isCompleted)
        {
            //if (user != null)
            //{
            //    Completedlevel completedLevel = new()
            //    {
            //        LevelId = stressLevelId,
            //        UserId = user.ChatId,
            //        IsCompleted = isCompleted
            //    };
            //    MainDB.Instance.Completedlevels.Add(completedLevel);
            //    MainDB.Instance.SaveChanges();
            //}
        }
    }
}