using DesignPatterns.ObserverPattern.DemoPractice.Observers;
namespace DesignPatterns.ObserverPattern.DemoPractice.Subjects;

public class Subject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    //Push style Observable
    // public void NotifyObservers(string data)
    // {
    //     foreach (var observer in _observers)
    //     {
    //         Push style Observable
    //          observer.Update(data ?? "Default");
    //     }
    // }
    
    //Pull style Observable
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            //Pull style Observable
            observer.Update();
        }
    }
}