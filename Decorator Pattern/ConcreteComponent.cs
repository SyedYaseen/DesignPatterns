namespace DesignPatterns.Decorator_Pattern;

public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("Doing some stuff");
    }
}