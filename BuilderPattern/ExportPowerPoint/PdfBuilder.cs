namespace DesignPatterns.BuilderPattern.ExportPowerPoint;

public class PdfBuilder : IPresentationBuilder
{
    private PdfDocument _pdf = new PdfDocument();
    public void AddSlide(Slide slide)
    {
        _pdf.AddPage(slide.GetText());
    }

    public PdfDocument GetPdf()
    {
        return _pdf;
    }
}
