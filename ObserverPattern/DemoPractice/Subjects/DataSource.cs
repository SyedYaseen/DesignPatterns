using DesignPatterns.ObserverPattern.DemoPractice.Observers;

namespace DesignPatterns.ObserverPattern.DemoPractice.Subjects;

public class DataSource : Subject
{
    private string data;

    public string GetData()
    {
        return data;
    }

    public void SetData(string value)
    {
        data = value;
        Console.WriteLine(value);
        
        //Push style
        // NotifyObservers(data);
        
        //Pull style
        NotifyObservers();
    }
}