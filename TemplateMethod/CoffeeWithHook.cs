using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class CoffeeWithHook:CoffeeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Driping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding surag and milk");
        }
        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string GetUserInput()
        {
            string res = null;
            Console.WriteLine("Would you like sugar and milk with your coffee (y/n)?");
            res = Console.ReadLine();
            return res;
        }
    }
}
