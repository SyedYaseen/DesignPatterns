namespace DesignPatterns.AbstractFactory.Device;

public class AndroidUi : IUiFactory
{
    public string CreateButton()
    {
        return "Android button";
    }
}