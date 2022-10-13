namespace DesignPatterns.StrategyPattern.Demo.Filters;

public class VividFilter : IFilter
{
    public void Apply(string fileName)
    {
        Console.WriteLine("Applying vivid filter");
    }
}