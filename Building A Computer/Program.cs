using Building_A_Computer;
using Building_A_Computer.CPUModels;
using Building_A_Computer.MotherBordModels;
using Building_A_Computer.RAMModels;
using Building_A_Computer.VideoCardModels;

namespace BuildingAComputer;
public class Program
{
    static void Main(string[] args)
    {
        List<IChooseComputer> components = new List<IChooseComputer>()
        {

             new IntelI5(),
             new ASUSPrime(),
             new NVIDIAGeForceGT1030(),
             new Crucial8Gb(),

        };
        components[0].CPU();
        Console.WriteLine();
        components[1].MotherBord();
        Console.WriteLine();
        components[2].VideoCard();
        Console.WriteLine();
        components[3].RAM();

    }
}

