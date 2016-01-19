using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.Pizzas
{
    abstract class Pizza
    {
        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Papperoni papperoni;
        protected Clams clams;
        public abstract void Prepare();
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
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
