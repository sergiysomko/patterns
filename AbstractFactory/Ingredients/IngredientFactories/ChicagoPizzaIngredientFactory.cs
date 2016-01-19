using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.Ingredients.IngredientFactories
{
    class ChicagoPizzaIngredientFactory:PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
            
        }
        public Sauce CreateSauce()
        {
            return new PlumTomatSauce();
        }
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = new Veggies[] { new Eggplant(), new BlackOlives(), new Spinach() };
            return veggies;
        }
        public Papperoni CreatePapperoni()
        {
            return new SlicedPapperoni();
        }
        public Clams CreateClams()
        {
            return new FrozenClams();
        }

    }
}
