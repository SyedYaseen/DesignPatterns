namespace DesignPatterns.PrototypePattern.Demo;

public interface IComponent
{
    string Render();
    IComponent Duplicate();
}