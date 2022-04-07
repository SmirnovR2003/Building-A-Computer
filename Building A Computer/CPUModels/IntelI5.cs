using BuildingAComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer.CPUModels
{
    public class IntelI5 : CPUIs
    {
        public override string model => "IntelI5";
        public override int numberOfCores => 6;
        public override int clockFrequencyMHz => 2900;
    }
}
