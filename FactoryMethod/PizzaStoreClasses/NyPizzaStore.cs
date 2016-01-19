using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.PizzaClasses;
using FactoryMethod.PizzaClasses.NY;

namespace FactoryMethod.PizzaStoreClasses
{
    class NyPizzaStore:PizzaStore
    {
        protected override Pizza Create(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NyStyleCheesePizza();
                default:
                    return null;
            }
        }
    }
}
