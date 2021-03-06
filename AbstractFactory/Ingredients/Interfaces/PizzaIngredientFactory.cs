﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ingredients.Interfaces
{
    interface PizzaIngredientFactory
    {
         Dough CreateDough();
         Sauce CreateSauce();
         Cheese CreateCheese();
         Veggies[] CreateVeggies();
         Papperoni CreatePapperoni();
         Clams CreateClams();
    }
}
