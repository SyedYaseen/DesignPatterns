using DesignPatterns.BridgePattern.ImplementationHierarchy;

namespace DesignPatterns.BridgePattern.FeatureHierarchy;

public class BasicRemote
{
    protected IDevice _device;

    public BasicRemote(IDevice device)
    {
        _device = device;
    }

    public void TurnOn()
    {
        _device.TurnOn();
    }

    public void TurnOff()
    {
        _device.TurnOff();
    }
    
}