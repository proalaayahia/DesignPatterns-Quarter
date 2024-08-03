namespace ObserverPattern.Core;

// The Subject interface
internal interface ISubject
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify(string product);
}
