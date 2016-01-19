using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PizzaClasses.NY
{
    class NyStyleCheesePizza:Pizza
    {
        public NyStyleCheesePizza()
        {
            this.Name = "NY Style Sauce and Cheese Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";

            this.Toppings.Add("Grated Reggiano Chesse");
        }
    }
}
