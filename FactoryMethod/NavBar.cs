namespace DesignPatterns.FactoryMethod;

public class NavBar
{
    public string CreateButton()
    {
        return ButtonFactory.CreateButton();
    }
}