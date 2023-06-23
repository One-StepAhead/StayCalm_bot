using StayCalmBot.Domain.Abstractions;
using StayCalmBot.Domain.Commands;
using StayCalmBot.Exercises;
using Telegram.Bot;
using Update = Telegram.Bot.Types.Update;

namespace StayCalmBot.Controllers
{
    public class BotController
    {
        private readonly ITelegramBotClient _telegramBotClient;
        private readonly ICommandService _commandService;

        public BotController(ICommandService commandService, ITelegramBotClient telegramBotClient)
        {
            _commandService = commandService;
            _telegramBotClient = telegramBotClient;
        }

        public async Task CommandProcessing(Update update)
        {
            if (update == null) return;

            var message = update.Message;
            string text = message?.Text;
            bool commandFound = false;

            if (message != null)
            {
                foreach (var command in from command in _commandService.Get()
                                        where command.Contains(message)
                                        select command)
                {
                    await command.Execute(message, _telegramBotClient);
                    commandFound = true;
                    break;
                }
            }

            if (!commandFound)
            {
                await _telegramBotClient.SendTextMessageAsync(message?.Chat.Id, "Команда неизвестна");
            }
        }

        public static async Task InlineKeyboardProcessing(ITelegramBotClient botClient, Update update)
        {
            if (update.CallbackQuery == null) return;

            var callbackQuery = update.CallbackQuery;

            if (callbackQuery != null)
            {
                bool commandCheck(List<string> commandArray) => commandArray.Contains(callbackQuery!.Data);
                bool stressLevelSelected(string commandArray) => commandArray.Contains(callbackQuery!.Data);

                if (commandCheck(MainCommands.commands))
                    await MainCommands.ShowExercises(callbackQuery, botClient);

                if (commandCheck(ExercisesForHighStressLvl.firstIterationCommands))
                    await ExercisesForHighStressLvl.ShowFirstListExercises(callbackQuery, botClient);

                if (commandCheck(ExercisesForHighStressLvl.secondIterationCommands))
                    await ExercisesForHighStressLvl.ShowSecondListExercises(callbackQuery, botClient);

                if (commandCheck(ExercisesForMediumStressLvl.commands))
                    await ExercisesForMediumStressLvl.ShowExercises(callbackQuery, botClient);

                if (commandCheck(ExercisesForWeakStressLvl.commands))
                    await ExercisesForWeakStressLvl.ShowExercises(callbackQuery, botClient);
            }
        }
    }
}
