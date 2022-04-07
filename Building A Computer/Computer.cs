using BuildingAComputer;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_A_Computer
{
    public class Computer
    {
        CPUIs cpuIs = new();
        MotherBordIs motherBordIs = new();
        RAMIs ramIs = new();
        VideoCardIs videoCardIs = new();
        public void CheckComponent()
        {
            try
            {
                if (cpuIs.model == null)
                {
                    throw new ArgumentException("CPU model muctn't be null");
                }
                if (cpuIs.numberOfCores < 1)
                {
                    throw new ArgumentException("CPU number of cores must be => 1");
                }
                if (cpuIs.clockFrequencyMHz < 1)
                {
                    throw new ArgumentException("CPU clock frequency must be => 1");
                }


                if (motherBordIs.model == null)
                {
                    throw new ArgumentException("Motherbord model mustn't be null");
                }
                if (motherBordIs.memorySlotsCount < 1)
                {
                    throw new ArgumentException("Motherbord memory slots count must be => 1");
                }


                if (ramIs.model == null)
                {
                    throw new ArgumentException("RAM model mustn't be null");
                }
                if (ramIs.memorySizeGb < 1)
                {
                    throw new ArgumentException("RAM memory size must be => 1");
                }
                if (ramIs.memoryType == null)
                {
                    throw new ArgumentException("RAM memory type mustn't be null");
                }


                if (videoCardIs.model == null)
                {
                    throw new ArgumentException("Videocard model mustn't be null");
                }
                if (videoCardIs.videoMmemorySizeMB < 1)
                {
                    throw new ArgumentException("Videocard video memory size must be => 1");
                }
                if (videoCardIs.gpuFrequencyMHz < 1)
                {
                    throw new ArgumentException("Videocard gpu frequency must be => 1");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
