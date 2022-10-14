namespace DesignPatterns.ChainOfResponsibilityPattern.DemoPractice.Handlers;

public class Compression : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Compressing stuff");
        return false;
    }

    public Compression(Handler next) : base(next)
    {
    }
}