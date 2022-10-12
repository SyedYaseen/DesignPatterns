namespace DesignPatterns.BuilderPattern;

public class Director
{
    private IBuilder _builder;

    public IBuilder Builder
    {
        set => _builder = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public void CreateMinimumProduct()
    {
        _builder.AddPart1();
    }
    
    public void CreateFullProduct()
    {
        CreateMinimumProduct();
        _builder.AddPart2();
        _builder.AddPart3();
    }
}