using DesignPatterns.AbstractFactory.Device;

namespace DesignPatterns.AbstractFactory;

public class NavBar
{
    public NavBar(IUiFactory buttonFactory)
    {
        Console.WriteLine($"Navbar {buttonFactory.CreateButton()}");
    }
}