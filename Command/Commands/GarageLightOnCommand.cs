using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class GarageLightOnCommand:LightOnCommand
    {
        public GarageLightOnCommand(Light light) : base(light) { }
    }
}
