namespace DesignPatterns.ChainOfResponsibilityPattern.DemoPractice;

public class HttpRequest
{

    private string _name { get; set; }
    private int _password { get; set; }

    public HttpRequest(string name, int password)
    {
        _name = name;
        _password = password;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPassword()
    {
        return _password;
    }
}