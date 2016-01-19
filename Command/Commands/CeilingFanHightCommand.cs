using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CeilingFanHightCommand:Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanHightCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            this.prevSpeed = this.ceilingFan.GetSpeed();
            this.ceilingFan.Hight();
            Console.WriteLine(this.ceilingFan.GetSpeed());

        }
        public void Undo()
        {
            if (this.prevSpeed == CeilingFan.HIGHT)
                ceilingFan.Hight();
            else if (this.prevSpeed == CeilingFan.MEDIUM)
                ceilingFan.Medium();
            else if (this.prevSpeed == CeilingFan.LOW)
                ceilingFan.Low();
            else if (this.prevSpeed == CeilingFan.OFF)
                ceilingFan.Off();
            else throw new Exception("i dont know this speed");
            Console.WriteLine(this.ceilingFan.GetSpeed());
        }

    }

}
