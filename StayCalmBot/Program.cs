using Telegram.Bot;
using Telegram.Bot.Polling;
using Update = Telegram.Bot.Types.Update;
using StayCalmBot.Controllers;
using StayCalmBot.Domain.Services;
using StayCalmBot.Domain.Abstractions;
using Telegram.Bot.Types;
using Telegram.Bots.Types;

namespace StayCalmBot
{
    class Program
    {
        static readonly ITelegramBotClient bot = new TelegramBotClient("5990328782:AAFCUipLaG4Te7tFpeKzwwtpsNbp48ZEkl4");
        static readonly ICommandService command = new CommandService();

        static void Main(string[] args)
        {
            Console.WriteLine($"Бот {bot.GetMeAsync().Result.FirstName} успешно запущен!\n");

            var cancellationToken = new CancellationTokenSource().Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { },
            };

            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

            Console.ReadLine();
        }

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));

            _ = new BotController(command, botClient).CommandProcessing(update);
            _ = BotController.InlineKeyboardProcessing(botClient, update);

            //var message = update.Message;

            //if (message == null || message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
            //    return;
            //else
            //{
            //    var chatId = update.Message.Chat.Id;

            //    if (!resultsCollector.ContainsKey(chatId))
            //    {
            //        resultsCollector.Add(chatId, new ResultsCollector());
            //    }

            //    var data = resultsCollector[chatId];

            //    switch (data.Step)
            //    {
            //        case 0:
            //            await bot.SendTextMessageAsync(chatId, "Как вас зовут?");
            //            data.Step++;
            //            break;
            //        case 1:
            //            data.Name = message.Text;
            //            await bot.SendTextMessageAsync(chatId, "Введите ваш номер телефона:");
            //            data.Step++;
            //            break;
            //        case 2:
            //            data.Phone = message.Text;
            //            await bot.SendTextMessageAsync(chatId, "Введите ваш email:");
            //            data.Step++;
            //            break;
            //        case 3:
            //            data.Email = message.Text;
            //            await bot.SendTextMessageAsync(chatId, "Ваши контактные данные:\n" +
            //                "Имя: " + data.Name + "\n" +
            //                "Телефон: " + data.Phone + "\n" +
            //                "Email: " + data.Email + "\n\n" +
            //                "Спасибо за ввод данных!");
            //            data.Step = 0;
            //            break;
            //    }
            //}
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

    }
}