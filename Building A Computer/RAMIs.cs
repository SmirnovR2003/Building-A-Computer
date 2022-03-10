using BuildingAComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer
{
    public class Crucial8Gb : Components
    {
        public string model = "Crucial CT8G4DFRA266";
        public int memorySizeGb = 8;
        public string memoryType = "DDR4";
        public override void RAM()
        {
            base.RAM();
            Console.WriteLine($"    model: {model}");
            Console.WriteLine($"    memory Size, Gb: {memorySizeGb}");
            Console.WriteLine($"    memory Type: {memoryType}");
        }
    }

    public class PatriotSignature : Components
    {
        public string model = "Patriot Signature PSD48G266681";
        public int memorySizeGb = 8;
        public string memoryType = "DDR4";
        public override void RAM()
        {
            base.RAM();
            Console.WriteLine($"    model: {model}");
            Console.WriteLine($"    memory Size, Gb: {memorySizeGb}");
            Console.WriteLine($"    memory Type: {memoryType}");
        }
    }
    
}
