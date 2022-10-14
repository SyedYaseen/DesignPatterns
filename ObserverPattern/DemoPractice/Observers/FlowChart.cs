using DesignPatterns.ObserverPattern.DemoPractice.Subjects;

namespace DesignPatterns.ObserverPattern.DemoPractice.Observers;

public class FlowChart : IObserver
{
    private readonly DataSource _dataSource;

    //This coupling is good and its used for pull style observer
    public FlowChart(DataSource dataSource)
    {
        _dataSource = dataSource;
    }
    
    //Check interface for notes on push style implementation
    public void Update()
    {
        var updatedData = _dataSource.GetData();
        Console.WriteLine($"{this.GetType().Name} Updated value is : {updatedData}");
    }
}