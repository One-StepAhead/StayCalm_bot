using StayCalmBot.Domain.Abstractions;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Args;
using StayCalmBot.Domain.Properties;
using StayCalmBot.Domain.Services;
using Telegram.Bot.Types.ReplyMarkups;

namespace StayCalmBot.Domain.Commands
{
    public class ConnectPsychCommand : TelegramCommand
    {
        private static readonly Dictionary<long, ResultsCollector> resultsCollector = new Dictionary<long, ResultsCollector>();

        public override string Name => "/callpsych";

        public override bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }

        public override async Task Execute(Message message, ITelegramBotClient client)
        {
            //InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(new[]
            //{
            //    new[] { InlineKeyboardButton.WithCallbackData("Телефон", "Phone") },
            //    new[] { InlineKeyboardButton.WithCallbackData("Почта", "Email") }
            //});
            //await client.SendTextMessageAsync(message.Chat.Id,
            //                                 "Оставь свои контактные данные, чтобы мы могли связаться с тобой.\r\n\r\nВыбери удобный для тебя способ связи👇",
            //                                 replyMarkup: inlineKeyboard);

            //await client.SendTextMessageAsync(message.Chat.Id, "Введите ваше имя:");
            //var update = await WaitForReply(client, message.Chat.Id);

            //string name = update.Message.Text;

            await client.SendTextMessageAsync(message.Chat.Id, "Ваше заявка на консультацию отправлена! В скором времени с вами свяжутся.");

            EmailSender email = new EmailSender("diyarov.amir.r@gmail.com", "ovcyepfiuskjuehf", "smtp.gmail.com", 587);
            email.SendEmail("amir.diarov@yandex.ru",
                "Вам поступила новая заявка!",
                $"ID чата: {message.Chat.Id}" +
                $"\nОт пользователя: {message.Chat.FirstName}" +
                $"\nUserLogin: {message.Chat.Username}");

            Console.WriteLine("\nПисьмо отправлено\n");
        }
    }
}
