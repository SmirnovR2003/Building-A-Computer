using BuildingAComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer
{
    public class VideoCardIs : Components
    {
        public virtual string model {get;}
        public virtual int gpuFrequencyMHz { get; }
        public virtual int videoMmemorySizeMB { get; }
        public override void VideoCard()
        {
            base.VideoCard();
            Console.WriteLine($"    model: {model}");
            Console.WriteLine($"    GPU frequency, MHz: {gpuFrequencyMHz}");
            Console.WriteLine($"    video Mmemory Size, MB: {videoMmemorySizeMB}");
        }
    }
}
