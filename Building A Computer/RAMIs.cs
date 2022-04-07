using BuildingAComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer
{
    public class RAMIs : Components
    {
        public virtual string model { get; }
        public virtual int memorySizeGb { get; }
        public virtual string memoryType { get; }
        public override void RAM()
        {
            base.RAM();
            Console.WriteLine($"    model: {model}");
            Console.WriteLine($"    memory Size, Gb: {memorySizeGb}");
            Console.WriteLine($"    memory Type: {memoryType}");
        }
    }
}
