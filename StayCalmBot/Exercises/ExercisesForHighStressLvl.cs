using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using StayCalmBot.Controllers;

namespace StayCalmBot.Exercises
{
    public static class ExercisesForHighStressLvl
    {
        private static readonly List<string> firstIteration = new()
        {
            "HighStressLVL_FirstRound",
            "HighStressLVL_FirstRound_Step_1",
            "HighStressLVL_FirstRound_Step_2",
            "HighStressLVL_FirstRound_Step_3",
            "HighStressLVL_FirstRound_Step_4",
            "HighStressLVL_FirstRound_Step_5",
            "HighStressLVL_FirstRound_Step_6",
            "HighStressLVL_FirstRound_Step_7",
            "HighStressLVL_FirstRound_Step_8",
            "HighStressLVL_FirstRound_Step_9",
            "HighStressLVL_FirstRound_Step_10",
            "HighStressLVL_FirstRound_Assessment",
            "Transition_FromHighToMediumLevel",
            "Transition_FromHighToWeakevel",
        };

        private static readonly List<string> secondIteration = new()
        {
            "HighStressLVL_SecondRound",
            "HighStressLVL_SecondRound_Step_1",
            "HighStressLVL_SecondRound_Step_2",
            "HighStressLVL_SecondRound_Step_3",
            "HighStressLVL_SecondRound_Step_4",
            "HighStressLVL_SecondRound_Step_5",
            "HighStressLVL_SecondRound_Step_6",
            "HighStressLVL_SecondRound_Step_7",
            "HighStressLVL_SecondRound_Assessment",
            "HighStressLVL_SecondRound_Finish",
            "HighStressLVL_EndOfExercises",
        };

        public static readonly List<string> firstIterationCommands = firstIteration;
        public static readonly List<string> secondIterationCommands = secondIteration;

        public static async Task ShowFirstListExercises(CallbackQuery callbackQuery, ITelegramBotClient botClient)
        {
            long ChatID = callbackQuery.Message.Chat.Id;
            const int highStressLevel = 1;
            const int isCompleted_Yes = 1;
            const int isCompleted_No = 0;

            switch (callbackQuery.Data)
            {
                case "HighStressLVL_FirstRound":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound, replyMarkup: GetIKForFirstRound());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_1":
                    await botClient.SendPhotoAsync(ChatID, "https://ibb.co/9HBt6WR", Properties.i18n.Strings.HighStressLvl_FirstRound_Step_1, replyMarkup: GetIKForFirstRoundStep1());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_2":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_2, replyMarkup: GetIKForFirstRoundStep2());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_3":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_3, replyMarkup: GetIKForFirstRoundStep3());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_4":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_4, replyMarkup: GetIKForFirstRoundStep4());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_5":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_5, replyMarkup: GetIKForFirstRoundStep5());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_6":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_6, replyMarkup: GetIKForFirstRoundStep6());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_7":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_7, replyMarkup: GetIKForFirstRoundStep7());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_8":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_8, replyMarkup: GetIKForFirstRoundStep8());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_9":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_9, replyMarkup: GetIKForFirstRoundStep9());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Step_10":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_FirstRound_Step_10, replyMarkup: GetIKForFirstRoundStep10());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_FirstRound_Assessment":
                    
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.StressLevelAssessment, replyMarkup: GetIKForFirstRoundAssessment());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "Transition_FromHighToMediumLevel":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.Transition_FromHighToMediumLevel, replyMarkup: GetIKForFirstRoundStep11());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "Transition_FromHighToWeakevel":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.Transition_FromHighToWeakevel, replyMarkup: GetIKForFirstRoundStep12());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;
            }
        }

        private static InlineKeyboardMarkup GetIKForFirstRound()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Приступим", "HighStressLVL_FirstRound_Step_1") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep1()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("▶ Запустить таймер и начать", "HighStressLVL_FirstRound_Step_2") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep2()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "HighStressLVL_FirstRound_Step_3") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep3()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Продолжаем", "HighStressLVL_FirstRound_Step_4") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep4()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("▶ Начнем", "HighStressLVL_FirstRound_Step_5") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep5()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Готово. Дальше", "HighStressLVL_FirstRound_Step_6") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep6()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Готово. Дальше", "HighStressLVL_FirstRound_Step_7") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep7()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Готово. Дальше", "HighStressLVL_FirstRound_Step_8") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep8()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Готово. Дальше", "HighStressLVL_FirstRound_Step_9") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep9()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Готово.", "HighStressLVL_FirstRound_Step_10") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep10()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "HighStressLVL_FirstRound_Assessment") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundAssessment()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new []{InlineKeyboardButton.WithCallbackData("❗️ Уровень стресса 9-10", "HighStressLVL_SecondRound") },
                new []{InlineKeyboardButton.WithCallbackData("⚠️ Уровень стресса 6-8", "Transition_FromHighToMediumLevel") },
                new[] { InlineKeyboardButton.WithCallbackData("🟡 Уровень стресса 1-5", "Transition_FromHighToWeakevel") }
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep11()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new []{InlineKeyboardButton.WithCallbackData("⏺ Закончим здесь", "EndOfAssistance") },
                new []{InlineKeyboardButton.WithCallbackData("▶ Продолжим", "MediumStressLVL") },
            });
        }

        private static InlineKeyboardMarkup GetIKForFirstRoundStep12()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new []{InlineKeyboardButton.WithCallbackData("⏺ Закончим здесь", "EndOfAssistance") },
                new []{InlineKeyboardButton.WithCallbackData("▶ Продолжим", "WeakStressLVL") },
            });
        }

        public static async Task ShowSecondListExercises(CallbackQuery callbackQuery, ITelegramBotClient botClient)
        {
            long ChatID = callbackQuery.Message.Chat.Id;

            switch (callbackQuery.Data)
            {
                case "HighStressLVL_SecondRound":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_SecondRound, replyMarkup: GetIKForSecondRound());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_SecondRound_Step_1":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_SecondRound_Step_1, replyMarkup: GetIKForSecondRoundStep1());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_SecondRound_Step_2":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_SecondRound_Step_2, replyMarkup: GetIKForSecondRoundStep2());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_SecondRound_Step_3":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_SecondRound_Step_3, replyMarkup: GetIKForSecondRoundStep3());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_SecondRound_Step_4":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_SecondRound_Step_4, replyMarkup: GetIKForSecondRoundStep4());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_SecondRound_Step_5":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_SecondRound_Step_5, replyMarkup: GetIKForSecondRoundStep5());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_SecondRound_Step_6":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_SecondRound_Step_6, replyMarkup: GetIKForSecondRoundStep6());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_SecondRound_Assessment":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.StressLevelAssessment, replyMarkup: GetIKForSecondRoundAssessment());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_SecondRound_Step_7":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_SecondRound_Finish, replyMarkup: GetIKForSecondRoundStep7());
                    await botClient.AnswerCallbackQueryAsync(callbackQuery.Id);
                    break;

                case "HighStressLVL_EndOfExercises":
                    await botClient.SendTextMessageAsync(ChatID, Properties.i18n.Strings.HighStressLvl_EndOfExercises);
                    break;
            }
        }

        private static InlineKeyboardMarkup GetIKForSecondRound()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("▶  Начнем", "HighStressLVL_SecondRound_Step_1") }
            });
        }

        private static InlineKeyboardMarkup GetIKForSecondRoundStep1()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "HighStressLVL_SecondRound_Step_2") }
            });
        }

        private static InlineKeyboardMarkup GetIKForSecondRoundStep2()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "HighStressLVL_SecondRound_Step_3") }
            });
        }

        private static InlineKeyboardMarkup GetIKForSecondRoundStep3()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано. Дальше", "HighStressLVL_SecondRound_Step_4") }
            });
        }

        private static InlineKeyboardMarkup GetIKForSecondRoundStep4()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("✅ Сделано", "HighStressLVL_SecondRound_Step_5") }
            });
        }

        private static InlineKeyboardMarkup GetIKForSecondRoundStep5()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Мне достаточно", "HighStressLVL_SecondRound_Step_6") },
                new[] { InlineKeyboardButton.WithCallbackData("🔄 Повторить", "HighStressLVL_SecondRound") }
            });
        }

        private static InlineKeyboardMarkup GetIKForSecondRoundStep6()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("🆗 Дальше", "HighStressLVL_SecondRound_Assessment") }
            });
        }

        private static InlineKeyboardMarkup GetIKForSecondRoundAssessment()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new []{InlineKeyboardButton.WithCallbackData("❗️ Уровень стресса 9-10", "HighStressLVL_SecondRound_Step_7") },
                new []{InlineKeyboardButton.WithCallbackData("⚠️ Уровень стресса 6-8", "MediumStressLVL")},
                new []{InlineKeyboardButton.WithCallbackData("🟡 Уровень стресса 1-5", "WeakStressLVL")}
            });
        }

        private static InlineKeyboardMarkup GetIKForSecondRoundStep7()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new []{InlineKeyboardButton.WithCallbackData("⏸ Пойду отвлекусь", "HighStressLVL_EndOfExercises") },
                new []{InlineKeyboardButton.WithCallbackData("🆗 Перейти к техникам", "HighStressLVL_FirstRound") },
            });
        }
    }
}
