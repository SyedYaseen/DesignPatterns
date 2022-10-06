using DesignPatterns.AbstractFactory.Device;

namespace DesignPatterns.AbstractFactory;

public class DropDown
{
    public DropDown(IUiFactory buttonFactory)
    {
        Console.WriteLine( $"Dropdown {buttonFactory.CreateButton()}");
    }
}