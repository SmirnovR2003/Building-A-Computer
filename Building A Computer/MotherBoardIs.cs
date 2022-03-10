namespace BuildingAComputer;
using System;
public class ASUSPrime : Components
{
    
    public string model = "ASUS PRIME H510M-K";
    public int memorySlotsCount = 2;
    public override void MotherBord()
    {
        base.MotherBord();
        Console.WriteLine($"    model: {model}");
        Console.WriteLine($"    Memory slots count: {memorySlotsCount}");
    }

}

public class ASROCKA320M : Components
{
    public string model = "ASROCK_A320M";
    public int memorySlotsCount = 2;
    public override void MotherBord()
    {
        base.MotherBord();
        Console.WriteLine($"    model: {model}");
        Console.WriteLine($"    Memory slots count: {memorySlotsCount}");
    }
}