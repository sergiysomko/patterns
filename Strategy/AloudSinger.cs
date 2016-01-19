using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class AloudSinger:ISingerable
    {
        public void Sing()
        {
            Console.WriteLine("I sing aloud");
        }
    }
}
