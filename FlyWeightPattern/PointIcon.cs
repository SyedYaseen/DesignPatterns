namespace DesignPatterns.FlyWeightPattern;

public class PointIcon
{
    // This is the flyweight class
    // This is the data that will be shared with other objects
    public PointType Type { get; }
    private readonly byte[] _icon;
     
    public PointIcon(PointType type, byte[] icon)
    {
        Type = type;
        _icon = icon;
    }
  }