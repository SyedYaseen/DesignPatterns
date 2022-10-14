using DesignPatterns.ObserverPattern.DemoPractice.Subjects;

namespace DesignPatterns.ObserverPattern.DemoPractice.Observers;

public interface IObserver
{
    // This is push style of communication
    //Its not very modular when different data types want
    //different types of child classes want different types of data
    //or if there is multiple properties
    // void Update(string data);
    
    //For pull style Observer
    void Update();
}