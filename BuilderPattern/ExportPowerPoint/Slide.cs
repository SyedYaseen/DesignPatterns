namespace DesignPatterns.BuilderPattern.ExportPowerPoint;

public class Slide
{
    private string _text;

    public Slide(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }
}