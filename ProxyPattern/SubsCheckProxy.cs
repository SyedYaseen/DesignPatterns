namespace DesignPatterns.ProxyPattern;

public class SubsCheckProxy : IEbook
{
    private RealEbook _realEbook;
    private string _fileName;

    public SubsCheckProxy(string fileName)
    {
        _fileName = fileName;
    }

    public void ShowEbook()
    {
        Console.WriteLine("Checking Subs");
        if (_realEbook == null) _realEbook = new RealEbook(_fileName);
        _realEbook.ShowEbook();
    }

    public string FilName()
    {
        return _fileName;
    }
}