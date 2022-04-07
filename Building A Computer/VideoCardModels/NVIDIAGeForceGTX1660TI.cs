using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer.VideoCardModels
{
    class NVIDIAGeForceGTX1660TI : VideoCardIs
    {
        public override string model => "Palit NVIDIA GeForce GTX 1660TI, PA-GTX1660Ti DUAL 6G";
        public override int gpuFrequencyMHz => 2400;
        public override int videoMmemorySizeMB => 6000;
    }
}
