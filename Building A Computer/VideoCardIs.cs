using BuildingAComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer
{
    public class NVIDIAGeForceGT1030 : Components
    {
        public string model = "GIGABYTE NVIDIA GeForce GT 1030, GV-N1030D5-2GL";
        public int gpuFrequencyMHz = 2300;
        public int videoMmemorySizeMB = 2000;
        public override void VideoCard()
        {
            base.VideoCard();
            Console.WriteLine($"    model: {model}");
            Console.WriteLine($"    GPU frequency, MHz: {gpuFrequencyMHz}");
            Console.WriteLine($"    video Mmemory Size, MB: {videoMmemorySizeMB}");
        }
    }

    public class NVIDIAGeForceGTX1660TI : Components
    {
        public string model = "Palit NVIDIA GeForce GTX 1660TI, PA-GTX1660Ti DUAL 6G";
        public int gpuFrequencyMHz = 2400;
        public int videoMmemorySizeMB = 6000;
        public override void VideoCard()
        {
            base.VideoCard();
            Console.WriteLine($"    model: {model}");
            Console.WriteLine($"    GPU frequency, MHz: {gpuFrequencyMHz}");
            Console.WriteLine($"    video Mmemory Size, MB: {videoMmemorySizeMB}");
        }
    }
}
