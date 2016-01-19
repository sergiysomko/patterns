using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget[] objs={new Target(),new Adapter(new Adaptee())};
            objs[0].Request();
            objs[1].Request();
            Console.ReadKey(true);
        }
    }
}
