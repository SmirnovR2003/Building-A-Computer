namespace BuildingAComputer;
using System;
public class IntelI5 : Components
{
    public string model = "Intel I5"; 
    public int numberOfCores = 6;
    public int clockFrequencyMHz = 2900;
    
    public override void CPU()
    {
        base.CPU();
        Console.WriteLine($"    model: {model}");
        Console.WriteLine($"    number of cores: {numberOfCores}");
        Console.WriteLine($"    clock frequency, MHz: {clockFrequencyMHz}");
    }
    
};

public class AMD : Components
{
    public string model = "AMD ryzen 5";
    public int numberOfCores = 6;
    public int clockFrequencyMHz = 3600;
    public override void CPU()
    {
        base.CPU();
        Console.WriteLine($"    model: {model}");
        Console.WriteLine($"    number of cores: {numberOfCores}");
        Console.WriteLine($"    clock frequency, MHz: {clockFrequencyMHz}");
    }
}