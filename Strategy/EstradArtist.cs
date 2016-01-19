using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class EstradArtist:Artist
    {
        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine("What did you say?");
        }
        public EstradArtist(string name):base(name)
        {
            DanceBehavior = new RumbaDancer();
            SongBehavior = new AloudSinger();
        }
    }
}
