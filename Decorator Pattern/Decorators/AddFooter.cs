namespace DesignPatterns.Decorator_Pattern.Decorators;

public class AddFooter : IComponent
{
    private IComponent _component;

    public AddFooter(IComponent component)
    {
        _component = component;
    }

    public void Operation()
    {
        _component.Operation();
        Console.WriteLine("Adding footer");
    }
}