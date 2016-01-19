using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Soy:Beverage
    {
        private Beverage beverage;
        public Soy(Beverage b)
        {
            this.beverage = b;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription()+", Soy";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }
    }
}
