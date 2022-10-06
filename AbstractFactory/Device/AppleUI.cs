namespace DesignPatterns.AbstractFactory.Device;

public class AppleUi : IUiFactory
{
    public string CreateButton()
    {
        return "Ios button";
    }
}