using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Mocha:CondimentDecorator
    {
        private Beverage beverage;
        public Mocha(Beverage b)
        {
            this.beverage = b;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription()+", Mocha";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}
