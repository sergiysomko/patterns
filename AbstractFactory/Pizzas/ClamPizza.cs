﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.IngredientFactories;
using AbstractFactory.Ingredients.Interfaces;


namespace AbstractFactory.Pizzas
{
    class ClamPizza:Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing "+this.name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clams = ingredientFactory.CreateClams();
        }
    }
}
