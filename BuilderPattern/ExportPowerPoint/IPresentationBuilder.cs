namespace DesignPatterns.BuilderPattern.ExportPowerPoint;

public interface IPresentationBuilder
{
    void AddSlide(Slide slide);
}