namespace DesignPatterns.ProxyPattern;

public class ProxyEbook : IEbook
{
    private RealEbook _realEbook;
    private string _fileName;

    public ProxyEbook(string fileName)
    {
        _fileName = fileName;
    }

    public void ShowEbook()
    {
        if (_realEbook == null) _realEbook = new RealEbook(_fileName);
        _realEbook.ShowEbook();
    }

    public string FilName()
    {
        return _fileName;
    }
}