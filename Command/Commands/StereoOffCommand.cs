using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class StereoOffCommand:Command
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            this.stereo.Off();
        }
        public void Undo()
        {
            this.stereo.On();
            this.stereo.SetCd();
            this.stereo.SetVolume(11);
        }
    }
}
