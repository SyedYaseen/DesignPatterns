using DesignPatterns.ChainOfResponsibilityPattern.DemoPractice.Handlers;

namespace DesignPatterns.ChainOfResponsibilityPattern.DemoPractice;

public class WebServer
{
    private Handler _handler;
    
    public WebServer(Handler handler)
    {
        _handler = handler;
    }

    public void Handle(HttpRequest request)
    {
        _handler.Handle(request);
    }
}