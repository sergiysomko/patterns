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
    class NyPizzaStore:PizzaStore
    {
        protected override Pizza Create(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NyPizzaIngredientFactory();
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("New York Style Cheese Pizza");
                    break;
                case "clams":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.SetName("New York Style Clam Pizza");
                    break;
                default:
                    pizza = null;
                    break;
            }
            return pizza;
        }
        

    }
}
