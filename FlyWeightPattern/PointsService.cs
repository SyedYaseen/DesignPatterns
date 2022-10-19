namespace DesignPatterns.FlyWeightPattern;

public class PointsService
{
    private PointIconFactory _iconFactory;

    public PointsService(PointIconFactory iconFactory)
    {
        _iconFactory = iconFactory;
    }

    public IEnumerable<Point> GetPoints()
    {
        List<Point> _points = new List<Point>
        {
            new Point(1,2, _iconFactory.GetPointIcon(PointType.GYM)),
            new Point(3,2, _iconFactory.GetPointIcon(PointType.HOSPITAL)),
            new Point(5,2, _iconFactory.GetPointIcon(PointType.RESTAURANT)),
        };
        
        return _points;
    }
}