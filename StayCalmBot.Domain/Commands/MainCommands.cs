using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace StayCalmBot.Domain.Commands
{
    public static class MainCommands
    {
        private static readonly List<string> list = new()
        {
            "Beginning",
            "SafePlace_Yes",
            "SafePlace_No",
            "EndOfAssistance",
            "BotStart",
        };

        public static readonly List<string> commands = list;

        public static async Task ShowExercises(CallbackQuery callbackQuery, ITelegramBotClient botClient)
        {
            long ChatID = callbackQuery.Message.Chat.Id;

            switch (callbackQuery.Data)
            {
                case "Beginning":
                    await botClient.SendTextMessageAsync(ChatID, "Ты сейчас в безопасном месте?", replyMarkup: GetInlineKeyboard_Beginning());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "SafePlace_Yes":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.StressLevelAssessment, replyMarkup: GetInlineKeyboard_SafePlace_Yes());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "SafePlace_No":
                    break;

                case "EndOfAssistance":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.EndOfAssistance, replyMarkup: GetInlineKeyboard_EndOfAssistance());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "BotStart":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.Interaction_Description, replyMarkup: GetInlineKeyboard_BotStart());
                    break;
            }
        }

        private static InlineKeyboardMarkup GetInlineKeyboard_Beginning()
        {
            return new InlineKeyboardMarkup(new[]
            {
                InlineKeyboardButton.WithCallbackData("✅ Да", "SafePlace_Yes"),
                InlineKeyboardButton.WithCallbackData("❌ Нет", "SafePlace_No"),
            });
        }

        private static InlineKeyboardMarkup GetInlineKeyboard_SafePlace_Yes()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new []{InlineKeyboardButton.WithCallbackData("❗️ Уровень стресса 9-10", "HighStressLVL_FirstRound")},
                new []{InlineKeyboardButton.WithCallbackData("⚠️ Уровень стресса 6-8", "MediumStressLVL")},
                new []{InlineKeyboardButton.WithCallbackData("🟡 Уровень стресса 1-5", "WeakStressLVL")}
            });
        }

        private static InlineKeyboardMarkup GetInlineKeyboard_EndOfAssistance()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new []{InlineKeyboardButton.WithCallbackData("Старт","BotStart")},
            });
        }

        private static InlineKeyboardMarkup GetInlineKeyboard_BotStart()
        {
            return new InlineKeyboardMarkup(new[]
            {
                InlineKeyboardButton.WithCallbackData(text: "🆗 Дальше", callbackData: "Beginning"),
            });
        }
    }
}
