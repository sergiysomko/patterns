using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singelton
    {
            
        private static Singelton uniqueInstance;
        private Singelton() { }
        public static Singelton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singelton();
            }
            return uniqueInstance;
        }
    }
}
