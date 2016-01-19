using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is On");
        }
        public void Off()
        {
            Console.WriteLine("Stereo is Off");
        }
        public void SetVolume(int vol)
        {
            Console.WriteLine("Volume set to {0}",vol);
        }
        public void SetDvd()
        {
            Console.WriteLine("");
        }
        public void SetCd()
        {
            Console.WriteLine("Stereo is set for CD input");
        }
        public void SetRadio()
        {
            Console.WriteLine("");
        }
    }
}
