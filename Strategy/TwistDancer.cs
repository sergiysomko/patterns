using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class TwistDancer: IDancerable
    {
        public void Dance()
        {
            Console.WriteLine("I dancing twist");
        }
    }
}
