using StayCalmBot.Domain.Abstractions;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace StayCalmBot.Domain.Commands
{
    public class StartCommand : TelegramCommand
    {
        public override string Name => "/start";

        public override bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }

        public override async Task Execute(Message message, ITelegramBotClient client)
        {
            InlineKeyboardMarkup inlineKeyboard = new(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData(text: "🆗 Дальше", callbackData: "Beginning"),
                },
            });

            await client.SendTextMessageAsync(message.Chat.Id, Properties.i18n.Strings.Interaction_Description, replyMarkup: inlineKeyboard);
        }
    }
}
