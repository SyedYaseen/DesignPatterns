namespace DesignPatterns.BridgePattern.ImplementationHierarchy;

public interface IDevice
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
}