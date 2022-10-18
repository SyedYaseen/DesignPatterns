namespace DesignPatterns.AdapterPattern.DemoPractice.Filters.ThirdPartyFilters;

public class Caramel
{
    public void Init()
    {
        
    }

    public void Render(Image image)
    {
        Console.WriteLine("Applying Caramel filter");
    }
}