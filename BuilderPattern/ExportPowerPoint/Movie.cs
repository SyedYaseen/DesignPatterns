namespace DesignPatterns.BuilderPattern.ExportPowerPoint;

public class Movie
{
    private List<string> frames = new List<string>();
    public void AddFrame(string text)
    {
        frames.Add(text + "movie frame");
    }
}