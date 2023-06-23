using System.Collections.Generic;
using StayCalmBot.Domain.Commands;
using StayCalmBot.Domain.Abstractions;

namespace StayCalmBot.Domain.Services
{
    public class CommandService: ICommandService
    {
        private readonly List<TelegramCommand> _commands;

        public CommandService()
        {
            _commands = new List<TelegramCommand>
            {
                new StartCommand(),
                new ConnectPsychCommand(),
            };
        }

        public List<TelegramCommand> Get() => _commands;
    }
}
