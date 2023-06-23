using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace StayCalmBot.Exercises
{
    public static class ExercisesForWeakStressLvl
    {
        private static readonly List<string> list = new()
        {
            "WeakStressLVL",
            "WeakStressLVL_Step_1",
            "WeakStressLVL_Step_2",
            "WeakStressLVL_Step_3",
            "WeakStressLVL_Step_4",
            "WeakStressLVL_Step_5",
            "WeakStressLVL_Step_6",
            "WeakStressLVL_Step_7",
            "WeakStressLVL_Step_8",
            "WeakStressLVL_Step_9",
            "WeakStressLVL_Repeat",
        };

        public static readonly List<string> commands = list;

        public static async Task ShowExercises(CallbackQuery callbackQuery, ITelegramBotClient botClient)
        {
            long ChatID = callbackQuery.Message.Chat.Id;

            switch (callbackQuery.Data)
            {
                case "WeakStressLVL":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl, replyMarkup: GetInlineKeyboard());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_1":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_1, replyMarkup: GetIKForStep1());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_2":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_2, replyMarkup: GetIKForStep2());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_3":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_3, replyMarkup: GetIKForStep3());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_4":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_4, replyMarkup: GetIKForStep4());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_5":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_5, replyMarkup: GetIKForStep5());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_6":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_6, replyMarkup: GetIKForStep6());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_7":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_7, replyMarkup: GetIKForStep7());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_8":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_8, replyMarkup: GetIKForStep8());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_Step_9":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Step_9, replyMarkup: GetIKForStep9());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "WeakStressLVL_RepeatExercises":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.WeakStressLvl_Repeat, replyMarkup: GetIKForRepeatExercises());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;
            }
        }

        private static InlineKeyboardMarkup GetInlineKeyboard()
        {
            return new InlineKeyboardMarkup(new[]
            {
                //new[] { InlineKeyboardButton.WithCallbackData("📖 К принципам", "WeakStressLVL_Principles_1") },
                new[] { InlineKeyboardButton.WithCallbackData("🔁 К упражнениям", "WeakStressLVL_Step_1") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep1()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Начнем", "WeakStressLVL_Step_2") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep2()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "WeakStressLVL_Step_3") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep3()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "WeakStressLVL_Step_4") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep4()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано", "WeakStressLVL_Step_5") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep5()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Начнем", "WeakStressLVL_Step_6") },
                new[] { InlineKeyboardButton.WithCallbackData("⏹ Не сейчас", "EndOfAssistance") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep6()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "WeakStressLVL_Step_7") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep7()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "WeakStressLVL_Step_8") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep8()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Готово", "WeakStressLVL_Step_9") }
            });
        }

        private static InlineKeyboardMarkup GetIKForStep9()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Да", "EndOfAssistance") },
                new[] { InlineKeyboardButton.WithCallbackData("❎ Нет", "WeakStressLVL") },
            });
        }

        private static InlineKeyboardMarkup GetIKForRepeatExercises()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🔁 Повторим упражнения", "WeakStressLVL") },
                new[] { InlineKeyboardButton.WithCallbackData("⏹ Не сейчас", "EndOfAssistance") },
            });
        }
    }
}
