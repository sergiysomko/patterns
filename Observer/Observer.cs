using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Observer
    {
        void Update(double t, double h, double p);
    }
}
