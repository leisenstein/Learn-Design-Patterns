using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Command_Pattern.Commands
{
    class NotFoundCommand : ICommand
    {
        public string Name { get; set; }
        
        public void Execute()
        {
            // FAKE Log Operation
            Console.WriteLine("LOG: Could not find command: {0}", Name);
        }
        
    }
}
