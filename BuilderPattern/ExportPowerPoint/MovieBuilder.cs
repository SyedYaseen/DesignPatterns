namespace DesignPatterns.BuilderPattern.ExportPowerPoint;

public class MovieBuilder : IPresentationBuilder
{
    private Movie _movie = new Movie();
    public void AddSlide(Slide slide)
    {
        _movie.AddFrame(slide.GetText());
    }

    public Movie GetMovie()
    {
        return _movie;
    }
}


