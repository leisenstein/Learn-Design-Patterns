using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_Command_Pattern.Commands;

namespace Learn_Command_Pattern.Commands
{
    public class UpdateOrderCommand : ICommand, ICommandFactory
    {
        // Implement Execute from ICommand and MakeCommand from ICommandFactory(CommandName,Description)
        public int NewQuantity { get; set; }
        
        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Updated"); // FAKE Database Operation

            // FAKE Log Operation
            Console.WriteLine("LOG: Updated order quanitty from {0} to {1}", oldQuantity, NewQuantity);
        }

        public string CommandName { get { return "UpdateOrder";  } }
        public string Description { get { return "UpdateOrder number"; } }

        public ICommand MakeCommand(string[] arguments)
        {
            // returns a new instance of itself like a Factory
            return new UpdateOrderCommand { NewQuantity = int.Parse(arguments[1]) };
        }
    }
}
