using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class StereoOnWithCdCommand:Command
    {
        private Stereo stereo;
        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            this.stereo.On();
            this.stereo.SetCd();
            this.stereo.SetVolume(11);
        }
        public void Undo()
        {
            this.stereo.Off();
        }
    }
}
