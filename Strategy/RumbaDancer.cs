using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class RumbaDancer:IDancerable
    {
        public void Dance()
        {
            Console.WriteLine("I dancing rumba");
        }
    }
}