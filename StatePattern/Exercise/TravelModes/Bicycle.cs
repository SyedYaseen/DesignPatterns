namespace DesignPatterns.StatePattern.Exercise.TravelModes;

public class Bicycle: ITravelMode
{
    public void GetETA()
    {
        Console.WriteLine("Calculating ETA (bicycling)");
    }

    public void GetDirection()
    {
        Console.WriteLine("Calculating Direction (bicycling)");
    }
}