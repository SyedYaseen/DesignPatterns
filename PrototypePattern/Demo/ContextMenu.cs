

namespace DesignPatterns.PrototypePattern.Demo;

public class ContextMenu
{
    public void Duplicate(IComponent component)
    {
        IComponent newComponent = component.Duplicate();
        //Added to any place we want
    }
}