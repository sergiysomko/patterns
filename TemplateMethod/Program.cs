using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaWithHook myTea = new TeaWithHook();
            CoffeeWithHook myCoffee = new CoffeeWithHook();
            Console.WriteLine("\tMaking tea");
            myTea.PrepareRecipe();
            Console.WriteLine("\tMaking coffee");
            myCoffee.PrepareRecipe();
            Console.ReadKey(true);
        }
    }
}
