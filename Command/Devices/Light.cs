using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Light
    {
        public Light(){}
        public void On()
        {
            Console.WriteLine("Light is On");
        }
        public void Off()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
