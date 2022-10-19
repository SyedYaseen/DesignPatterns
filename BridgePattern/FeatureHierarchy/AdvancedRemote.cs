using DesignPatterns.BridgePattern.ImplementationHierarchy;

namespace DesignPatterns.BridgePattern.FeatureHierarchy;

public class AdvancedRemote : BasicRemote
{
    public AdvancedRemote(IDevice device) : base(device)
    { }
    
    public void SetChannel(int channel)
    {
        _device.SetChannel(channel);
    }
    
}