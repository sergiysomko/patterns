using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pizzas;
using AbstractFactory.Ingredients.IngredientFactories;
using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.Stores
{
    class ChicagoPizzaStore:PizzaStore
    {
        protected override Pizza Create(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("Chicago Style Cheese Pizza");
                    break;
                case "clams":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.SetName("Chicago Style Clam Pizza");
                    break;
                default:
                    pizza = null;
                    break;
            }
            return pizza;
        }
    }
}
