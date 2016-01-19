using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pizzas;

namespace AbstractFactory.Stores
{
    abstract class PizzaStore
    {
        public Pizza Order(string type)
        {
            Pizza pizza = Create(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        protected abstract Pizza Create(string type);
    }
}
