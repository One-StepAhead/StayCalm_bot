using System.Collections.Generic;

namespace StayCalmBot.Domain.Abstractions
{
    public interface ICommandService
    {
        List<TelegramCommand> Get();
    }
}
