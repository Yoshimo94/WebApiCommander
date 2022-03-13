using System.Collections.Generic;
using WebApiCommander.Models;

namespace WebApiCommander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
