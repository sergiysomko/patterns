using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class GarageLightOffCommand:LightOffCommand
    {
        public GarageLightOffCommand(Light light) : base(light) { }
    }
}
