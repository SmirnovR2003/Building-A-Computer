using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer.VideoCardModels
{
    class NVIDIAGeForceGT1030 : VideoCardIs
    {
        public override string model => "GIGABYTE NVIDIA GeForce GT 1030, GV-N1030D5-2GL";
        public override int gpuFrequencyMHz => 2300;
        public override int videoMmemorySizeMB => 2000;
    }
}
