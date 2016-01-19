using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaClasses.Chicago
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.Name = "Chicago Style Deep Dish Cheese Pizza";
            this.Dough = "Extra Thick Crust Dought";
            this.Sauce = "Plum Tomato Sauce";

            this.Toppings.Add("Shredded Mozzarella Cheese");
        }
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
