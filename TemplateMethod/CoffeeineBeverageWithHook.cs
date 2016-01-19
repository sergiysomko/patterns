using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class CoffeeineBeverageWithHook
    {
        public void PrepareRecipe()
        {// template method
            this.BoilWater();
            this.Brew();
            this.PourInCup();
            if (CustomerWantsCondiments())
            {
                this.AddCondiments();
            }
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        public virtual bool CustomerWantsCondiments()
        {// перехватчик
            return true;
        }
        abstract public void Brew();
        abstract public void AddCondiments();
    }
}
