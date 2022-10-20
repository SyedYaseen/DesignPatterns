namespace DesignPatterns.ProxyPattern;

public class RealEbook : IEbook
{
    private string _fileName;

    public RealEbook(string fileName)
    {
        _fileName = fileName;
        LoadEbook();
    }

    private void LoadEbook()
    {
        Console.WriteLine($"Loading {_fileName}");
    }

    public void ShowEbook()
    {
        Console.WriteLine($"Showing {_fileName}");
    }

    public string FilName()
    {
        return _fileName;
    }
}