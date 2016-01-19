using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Artist
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != "")
                    _name = value;
                else throw new Exception("Name is empty");
            }
        }
        public ISingerable SongBehavior;
        public IDancerable DanceBehavior;
        public Artist() { }
        public Artist(string name)
        {
            Name = name;
            
        }
        public virtual void Sing()
        {
            SongBehavior.Sing();
        }
        public virtual void Dance()
        {
            DanceBehavior.Dance();
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Hello, I am " + this.Name);
        }
    }
}
