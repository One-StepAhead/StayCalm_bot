using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace StayCalmBot.Exercises
{
    public static class ExercisesForMediumStressLvl
    {
        public static List<string> commands = new()
        {
            "MediumStressLVL",
            "MediumStressLVL_Step_1",
            "MediumStressLVL_Step_2",
            "MediumStressLVL_Step_3",
            "MediumStressLVL_Step_4",
            "MediumStressLVL_Step_5",
            "MediumStressLVL_Step_6",
            "MediumStressLVL_Step_7",
            "MediumStressLVL_Step_8",
            "MediumStressLVL_Step_9",
            "MediumStressLVL_Step_10",
            "MediumStressLVL_Principles_1",
            "MediumStressLVL_Principles_2",
            "MediumStressLVL_Principles_3",
            "MediumStressLVL_Principles_4",
            "MediumStressLVL_Principles_5",
            "MediumStressLVL_Principles_6",
            "MediumStressLVL_RepeatExercises",
            "MediumStressLVL_NotNow",
        };

        public static async Task ShowExercises(CallbackQuery callbackQuery, ITelegramBotClient botClient)
        {
            long ChatID = callbackQuery.Message.Chat.Id;

            switch (callbackQuery.Data)
            {
                case "MediumStressLVL":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl, replyMarkup: GetInlineKeyboard());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_1":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_1, replyMarkup: GetIKForStep1());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_2":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_2, replyMarkup: GetIKForStep2());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_3":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_3, replyMarkup: GetIKForStep3());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_4":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_4, replyMarkup: GetIKForStep4());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_5":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_5, replyMarkup: GetIKForStep5());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_6":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_6, replyMarkup: GetIKForStep6());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_7":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_7, replyMarkup: GetIKForStep7());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_8":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_8, replyMarkup: GetIKForStep8());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_9":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_9, replyMarkup: GetIKForStep9());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_RepeatExercises":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_RepeatExercises, replyMarkup: GetIKForRepeatExercises());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_NotNow":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_NotNow, replyMarkup: GetIKForNotNow());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Principles_1":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Principles_1, replyMarkup: GetIKForPrinciples1());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Principles_2":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Principles_2, replyMarkup: GetIKForPrinciples2());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Principles_3":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Principles_3, replyMarkup: GetIKForPrinciples3());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Principles_4":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Principles_4, replyMarkup: GetIKForPrinciples4());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Principles_5":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Principles_5, replyMarkup: GetIKForPrinciples5());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Principles_6":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Principles_6, replyMarkup: GetIKForPrinciples6());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "MediumStressLVL_Step_10":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.MediumStressLvl_Step_10, replyMarkup: GetIKForStep10());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;
            }
        }

        private static InlineKeyboardMarkup GetInlineKeyboard()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new []{InlineKeyboardButton.WithCallbackData("▶ Приступим", "MediumStressLVL_Step_1") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep1()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "MediumStressLVL_Step_2") }
            });
        }

        private static InlineKeyboardMarkup GetIKForStep2()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "MediumStressLVL_Step_3") }
            });
        }

        private static InlineKeyboardMarkup GetIKForStep3()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано", "MediumStressLVL_Step_4") }
            });
        }

        private static InlineKeyboardMarkup GetIKForStep4()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Начнем", "MediumStressLVL_Step_5") },
                new[] { InlineKeyboardButton.WithCallbackData("❎ Не сейчас", "MediumStressLVL_NotNow") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep5()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "MediumStressLVL_Step_6") }
            });
        }

        private static InlineKeyboardMarkup GetIKForStep6()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "MediumStressLVL_Step_7") }
            });
        }

        private static InlineKeyboardMarkup GetIKForStep7()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Готово", "MediumStressLVL_Step_8") }
            });
        }

        private static InlineKeyboardMarkup GetIKForStep8()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Да", "MediumStressLVL_Step_9") },
                new[] { InlineKeyboardButton.WithCallbackData("❎ Нет", "MediumStressLVL_RepeatExercises") }
            });
        }

        private static InlineKeyboardMarkup GetIKForStep9()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("⏹ Закончим здесь", "EndOfAssistance") },
                new[] { InlineKeyboardButton.WithCallbackData("🔁 Повторим упражнения", "MediumStressLVL") },
                new[] { InlineKeyboardButton.WithCallbackData("📖 К принципам", "MediumStressLVL_Principles_1") },
            });
        }

        private static InlineKeyboardMarkup GetIKForStep10()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "EndOfAssistance") },
            });
        }

        private static InlineKeyboardMarkup GetIKForPrinciples1()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "MediumStressLVL_Principles_2") },
            });
        }

        private static InlineKeyboardMarkup GetIKForPrinciples2()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "MediumStressLVL_Principles_3") },
            });
        }

        private static InlineKeyboardMarkup GetIKForPrinciples3()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "MediumStressLVL_Principles_4") },
            });
        }

        private static InlineKeyboardMarkup GetIKForPrinciples4()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "MediumStressLVL_Principles_5") },
            });
        }

        private static InlineKeyboardMarkup GetIKForPrinciples5()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "MediumStressLVL_Principles_6") },
            });
        }

        private static InlineKeyboardMarkup GetIKForPrinciples6()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "MediumStressLVL_Step_10") },
            });
        }

        private static InlineKeyboardMarkup GetIKForRepeatExercises()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🔁 Повторим упражнения", "MediumStressLVL") },
                new[] { InlineKeyboardButton.WithCallbackData("⏹ Не сейчас", "MediumStressLVL_NotNow") },
            });
        }

        private static InlineKeyboardMarkup GetIKForNotNow()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 До свидания", "EndOfAssistance") },
            });
        }
    }
}
