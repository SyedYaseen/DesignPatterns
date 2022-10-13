namespace DesignPatterns.PrototypePattern.Demo;

public class Circle : IComponent
{
    private int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }
    
    public string Render()
    {
        return $"Circle with Radius: {_radius}";
    }

    public IComponent Duplicate()
    {
        return new Circle(_radius);
    }
}