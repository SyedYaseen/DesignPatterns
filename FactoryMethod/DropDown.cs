namespace DesignPatterns.FactoryMethod;

public class DropDown
{
    public string CreateButton()
    {
        return ButtonFactory.CreateButton();
    }
}