namespace DesignPatterns.ChainOfResponsibilityPattern.DemoPractice.Handlers;

public class Logger : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine("Loggin values");
        return false;
    }

    public Logger(Handler next) : base(next)
    {
    }
}