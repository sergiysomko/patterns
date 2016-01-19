using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Whip:Beverage
    {
        private Beverage beverage;
        public Whip(Beverage b)
        {
            this.beverage = b;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription()+", Whip";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
