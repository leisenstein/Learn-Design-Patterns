using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_Command_Pattern.Commands;

namespace Learn_Command_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var availableCommands = GetAvailableCommands();

            if(args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }

            // Make sure the command passed in teh args is a valid command
            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);

            // if it's a valid command, call Execute
            if (command != null)
                command.Execute();


            Console.ReadKey();
        }

        public static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[] {
                new CreateOrderCommand(),
                new UpdateOrderCommand(),
                new ShipOrderCommand()
            };
        }

        public static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Usage: LoggingDemo CommandName Arguments");
            Console.WriteLine("Commands:");

            foreach (var command in availableCommands)
            {
                Console.WriteLine("  {0}", command.Description);
            }
        }
    }
}
