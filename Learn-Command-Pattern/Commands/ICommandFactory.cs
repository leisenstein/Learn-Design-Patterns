using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_Command_Pattern.Commands;

namespace Learn_Command_Pattern.Commands
{
    public interface ICommandFactory
    {
        string CommandName { get; }
        string Description { get; }

        ICommand MakeCommand(string[] arguments);
    }
}
