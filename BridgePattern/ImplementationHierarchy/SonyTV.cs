namespace DesignPatterns.BridgePattern.ImplementationHierarchy;

public class SonyTV : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Turn on Sony TV");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turn off Sony TV");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"Sony: Set channel to {channel}");
    }
}