using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer.RAMModels
{
    class PatriotSignature : RAMIs
    {
        public override string model => "Patriot Signature PSD48G266681";
        public override int memorySizeGb => 8;
        public override string memoryType => "DDR4";
    }
}
