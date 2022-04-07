using BuildingAComputer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer.CPUModels
{
    class AMD : CPUIs
    {
        public override string model => "AMD ryzen 5";
        public override int numberOfCores => 6;
        public override int clockFrequencyMHz => 3600;
    }
}
