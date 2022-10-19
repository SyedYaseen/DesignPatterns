namespace DesignPatterns.FlyWeightPattern;

public class Point
{
    private int _X;
    private int _Y;
    private PointIcon _PointIcon;

    public Point(int x, int y, PointIcon pointIcon)
    {
        _X = x;
        _Y = y;
        _PointIcon = pointIcon;
    }
    
    public void Draw()
    {
        Console.WriteLine($"{_PointIcon.Type} at {_X} and {_Y}");
    }
}