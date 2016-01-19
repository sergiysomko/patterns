using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Target:ITarget
    {
        public void Request()
        {
            Console.WriteLine("perform request");
        }
    }
}
