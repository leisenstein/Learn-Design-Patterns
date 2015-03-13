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

        // Each Command will implement the ICommandFactory so I can create an instance of itself
        ICommand MakeCommand(string[] arguments);
    }
}
