using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class NoCommand:Command
    {
        public void Execute()
        {
            Console.WriteLine("<<empty command>>");
        }
        public void Undo()
        {
            Console.WriteLine("<<empty command>>");   
        }
    }
}
