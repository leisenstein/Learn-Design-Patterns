using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Command_Pattern.Commands
{
    class CreateOrderCommand : ICommand, ICommandFactory
    {
        public string CommandName { get { return "CreateOrder"; } }
        public string Description { get { return "CreateOrder Command"; } }


        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Create Order, Quantity Currently {0}", oldQuantity); // FAKE Database Operation

            // FAKE Log Operation
            Console.WriteLine("LOG: ORDER CREATED");
        }

     

        public ICommand MakeCommand(string[] arguments)
        {
            // returns a new instance of itself like a Factory
            return new CreateOrderCommand { };
        }
    }
}
