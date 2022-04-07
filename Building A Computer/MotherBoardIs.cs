namespace BuildingAComputer;
using System;
public class MotherBordIs : Components
{
    public virtual string model {get;}
    public virtual int memorySlotsCount {get;}
    public override void MotherBord()
    {
        base.MotherBord();
        Console.WriteLine($"    model: {model}");
        Console.WriteLine($"    Memory slots count: {memorySlotsCount}");
    }
}