using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Ingredients.Interfaces;

namespace AbstractFactory.Ingredients.IngredientFactories
{
    class NyPizzaIngredientFactory:PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies={new Garlic(),new Onion(),new Mushroom(),new RedPepper()};
            return veggies;
        }
        public Papperoni CreatePapperoni()
        {
            return new SlicedPapperoni();
        }
        public Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}
