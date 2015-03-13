using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Command_Pattern.Commands
{
    class ShipOrderCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }
        public string CommandName { get { return "ShipOrder"; } }
        public string Description { get { return "ShipOrder, Update Inventory"; } }

        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Shipped Order"); // FAKE Database Operation

            // FAKE Log Operation
            Console.WriteLine("LOG: Shipped Order.  Updated Quantity {0} to {1}", oldQuantity, --NewQuantity);
        }

        

        public ICommand MakeCommand(string[] arguments)
        {
            // returns a new instance of itself like a Factory
            return new ShipOrderCommand { NewQuantity = int.Parse(arguments[1]) };
        }
    }
}
