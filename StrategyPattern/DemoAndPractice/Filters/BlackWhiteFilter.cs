namespace DesignPatterns.StrategyPattern.Demo.Filters;

public class BlackWhiteFilter : IFilter
{
    public void Apply(string fileName)
    {
        Console.WriteLine("Applying Black and White Filter");
    }
}