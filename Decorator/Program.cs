using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Print(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());
        }
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            Print(beverage);
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Print(beverage2);
            Console.ReadKey(true);
        }
    }
}
