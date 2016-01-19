using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Artist> group = new List<Artist>();
            group.Add(new EstradArtist("Alyosha"));
            group.Add(new EstradArtist("Oleksandr"));
            group.Add(new OldArtist("Tursunbek"));
            foreach (var a in group)
            {
                a.SayHello();
                a.Sing();
                a.Dance();
            }
            group[2].SongBehavior = new AloudSinger();
            foreach (var a in group)
                a.Sing();
            Console.ReadKey(true);
        }
    }
}
