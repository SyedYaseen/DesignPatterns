namespace DesignPatterns.BuilderPattern.ExportPowerPoint;

public class PdfDocument
{
    private List<string> pages = new List<string>();

    public void AddPage(string text)
    {
        pages.Add(text + "Pdf page");
    }
}