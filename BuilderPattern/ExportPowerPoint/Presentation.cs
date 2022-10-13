namespace DesignPatterns.BuilderPattern.ExportPowerPoint;

//This is the (probably) director in builder pattern
public class Presentation
{
    private List<Slide> _slides = new List<Slide>();

    public void AddSlide(string text)
    {
        _slides.Add(new Slide(text));
    }

    public void Export(IPresentationBuilder builder)
    {
        builder.AddSlide(new Slide("Copyright"));
        foreach (var slide in _slides)
        {
            builder.AddSlide(slide);
        }
        builder.AddSlide(new Slide("End of presentation"));
    }
}