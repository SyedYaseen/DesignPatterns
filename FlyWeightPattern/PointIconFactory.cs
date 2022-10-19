namespace DesignPatterns.FlyWeightPattern;

public class PointIconFactory
{
    private Dictionary<PointType, PointIcon> _icons = new Dictionary<PointType, PointIcon>();
    public PointIcon GetPointIcon(PointType type)
    {
        if (!_icons.ContainsKey(type)) _icons.Add(type, new PointIcon(type, null));
        return _icons[type];
    }
}