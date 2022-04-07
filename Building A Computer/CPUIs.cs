namespace BuildingAComputer;
using System;
public class CPUIs : Components
{
    public virtual string model { get; }
    public virtual int numberOfCores { get; }
    public virtual int clockFrequencyMHz { get; }
    
    public override void CPU()
    {
        base.CPU();
        Console.WriteLine($"    model: {model}");
        Console.WriteLine($"    numberOfCores: {numberOfCores}");
        Console.WriteLine($"    clockFrequencyMHz: {clockFrequencyMHz}");
    }
}