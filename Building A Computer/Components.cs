

namespace BuildingAComputer;
public class Components : IChooseComputer
{

    public virtual void CPU()
    {
        Console.WriteLine("CPU info:");
    }
    public virtual void MotherBord()
    {
        Console.WriteLine("Motherboard info:");
    }

    public virtual void VideoCard()
    {
        Console.WriteLine("VideoCard info:");
    }

    public virtual void RAM()
    {
        Console.WriteLine("RAM info:");
    }
}
