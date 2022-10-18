namespace DesignPatterns.AdapterPattern.DemoPractice.Filters.ThirdPartyFilters;

public class CaramelAdapter : IFilter
{
    private Caramel _caramel;

    public CaramelAdapter(Caramel caramel)
    {
        _caramel = caramel;
    }

    public void Apply(Image image)
    {
        _caramel.Init();
        _caramel.Render(image);
    }
    
}