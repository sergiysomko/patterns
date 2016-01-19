using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaClasses
{
    abstract class Pizza
    {
        protected string Name ;
        protected string Dough;
        protected string Sauce;
        public List<string> Toppings;
        public Pizza()
        {
            Toppings = new List<string>();
        }
        public virtual void Prepare()
        {
            Console.WriteLine("Preparing "+this.Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding souce...");
            Console.WriteLine("Adding toppings:");
            foreach(var t in Toppings)
                Console.WriteLine(" "+t);
        }
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degree");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in offical PizzaStore box");
        }
        public string GetName()
        {
            return Name;
        }
    }
}
