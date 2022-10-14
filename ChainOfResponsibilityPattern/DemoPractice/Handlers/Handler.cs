namespace DesignPatterns.ChainOfResponsibilityPattern.DemoPractice.Handlers;

public abstract class Handler
{
    private Handler? next;
    
    public Handler(Handler next)
    {
        this.next = next;
    }
    
    public void Handle(HttpRequest request)
    {
        if (DoHandle(request)) return;
        if (next is not null) next.Handle(request);
    }
    
    public abstract bool DoHandle(HttpRequest request);
}