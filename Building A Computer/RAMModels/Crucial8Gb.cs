using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer.RAMModels
{
    class Crucial8Gb : RAMIs
    {
        public override string model => "Crucial CT8G4DFRA266";
        public override int memorySizeGb => 8;
        public override string memoryType => "DDR4";
    }
}
