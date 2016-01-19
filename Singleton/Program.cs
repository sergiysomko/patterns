using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singelton s = Singelton.GetInstance();
            Singelton s2 = Singelton.GetInstance();
        }
    }
}
