namespace DesignPatterns.BridgePattern.ImplementationHierarchy;

public class SamsungTV : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Samsung: Turn On");
    }

    public void TurnOff()
    {
        Console.WriteLine("Samsung: Turn Off");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"Samsung: Set channel to {channel}");
    }
}