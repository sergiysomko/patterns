using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class OldArtist:Artist
    {
        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine("Khe khe");
        }
        public OldArtist(string name):base(name)
        {
            DanceBehavior = new TwistDancer();
            SongBehavior = new SoftlySinger();
        }
    }
}
