namespace DesignPatterns.ChainOfResponsibilityPattern.DemoPractice.Handlers;

public class Authentication : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        var isValid = request.GetName() == "Admin" && 
                      request.GetPassword() == 1234 ? true : false;

        return !isValid;
    }

    public Authentication(Handler next) : base(next)
    {
    }
}