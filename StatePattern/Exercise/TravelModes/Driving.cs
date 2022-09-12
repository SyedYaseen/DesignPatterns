namespace DesignPatterns.StatePattern.Exercise.TravelModes;

public class Driving: ITravelMode
{
    public void GetETA()
    {
        Console.WriteLine("Calculating ETA (driving)");
    }

    public void GetDirection()
    {
        Console.WriteLine("Calculating Direction (driving)");
    }
}