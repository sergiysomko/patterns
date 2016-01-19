using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.PizzaClasses;

namespace FactoryMethod.PizzaStoreClasses
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
