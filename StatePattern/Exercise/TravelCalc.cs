namespace DesignPatterns.StatePattern.Exercise;

public class TravelCalc
{
    private readonly ITravelMode _currentTravelMode;

    public TravelCalc(ITravelMode travelMode)
    {
        _currentTravelMode = travelMode;
    }
    
    public void GetETA()
    {
       _currentTravelMode.GetETA();
    }

    public void GetTravelMode()
    {
        _currentTravelMode.GetDirection();
    }
}