namespace DesignPatterns.IteratorPattern;

public interface IIterator<T>
{
    T Current();
    void Next();
    bool HasNext();
}