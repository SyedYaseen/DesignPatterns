namespace DesignPatterns.FactoryPatternInheritance;

public class NavBar : Element
{
    public override Button CreateButton()
    {
        return new Button();
    }
}