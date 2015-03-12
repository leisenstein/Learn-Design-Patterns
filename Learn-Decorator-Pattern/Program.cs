using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Decorator_Pattern
{
    class Program
    {
        // This is from the PluralSight course on Design Patterns
        // http://www.pluralsight.com/courses/patterns-library

        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Peppers(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());



            // Pause
            Console.ReadKey();
        }
    }
}
