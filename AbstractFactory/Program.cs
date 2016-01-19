using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pizzas;
using AbstractFactory.Stores;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            PizzaStore nyStore = new NyPizzaStore();
            Pizza pizza = chicagoStore.Order("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName());
            pizza = nyStore.Order("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName());
            Console.ReadKey(true);
        }
    }
}
