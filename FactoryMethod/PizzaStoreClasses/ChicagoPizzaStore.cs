using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.PizzaClasses;
using FactoryMethod.PizzaClasses.Chicago;

namespace FactoryMethod.PizzaStoreClasses
{
    internal class ChicagoPizzaStore:PizzaStore
    {
        protected override Pizza Create(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                default:
                    return null;
            }
        }
    }
}
