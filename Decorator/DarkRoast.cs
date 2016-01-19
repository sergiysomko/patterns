using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast";

        }
        public override double Cost()
        {
            return 0.99;
        }
        
    }
}
