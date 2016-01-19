using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.IngredientFactories;
using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.Pizzas
{
    class CheesePizza:Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory; 
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing "+this.name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
        }
        public override void Cut()
        {
            if (ingredientFactory is ChicagoPizzaIngredientFactory)
            {
                Console.WriteLine("Cutting the pizza into square slices");
            }
            else
                base.Cut();
        }
    }
}
