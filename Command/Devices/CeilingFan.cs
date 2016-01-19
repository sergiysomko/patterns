using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CeilingFan
    {
        private int speed;
        public static int HIGHT = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        public CeilingFan()
        {
            this.speed = OFF;
        }
        public void Hight()
        {
            this.speed = HIGHT;
        }
        public void Medium()
        {
            this.speed = MEDIUM;
        }
        public void Low()
        {
            this.speed = LOW;
        }
        public void Off()
        {
            this.speed = OFF;
        }
        public int GetSpeed()
        {
            return this.speed;
        }
        
    }
}
