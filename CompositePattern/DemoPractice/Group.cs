using System.Security.Cryptography;

namespace DesignPatterns.CompositePattern.DemoPractice;

public class Group : IComponent
{
    private List<IComponent> items = new List<IComponent>();
    
    public Group()
    {
        
    }

    public void AddItems(IComponent item)
    {
        items.Add(item);
    }

    public void Render()
    {   
        foreach (var item in items)
        {
            item.Render();
        }
        
    }
}