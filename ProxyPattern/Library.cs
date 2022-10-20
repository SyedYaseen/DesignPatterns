namespace DesignPatterns.ProxyPattern;

public class Library
{
    private Dictionary<string, IEbook> _library = new Dictionary<string, IEbook>();

    public void AddEbook(IEbook ebook)
    {
        _library.Add(ebook.FilName(), ebook);
    }

    public void ReadBook(string fileName)
    { 
        _library[fileName].ShowEbook();
    }
}