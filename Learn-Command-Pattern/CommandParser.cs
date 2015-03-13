using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_Command_Pattern.Commands;

namespace Learn_Command_Pattern
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];

            var command = FindRequestedCommand(requestedCommandName);

            // instead of returning NULL, return a SAFE class that implements the interface
            if (command == null)
                return new NotFoundCommand { Name = requestedCommandName };

            return command.MakeCommand(args);
        }

        ICommandFactory FindRequestedCommand(string commandName)
        {
            // FirstOrDefault will return NULL if it does not find a CommandName
            return availableCommands.FirstOrDefault(cmd => cmd.CommandName == commandName);
        }
    }
}
