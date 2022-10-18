namespace DesignPatterns.Decorator_Pattern.Decorators;

public class AddHeader : IComponent
{
    private IComponent _component;


    public AddHeader(IComponent component)
    {
        _component = component;
    }

    public void Operation()
    {
        Console.WriteLine("Adding Header");
        _component.Operation();
    }
}