namespace ObserverPattern.Core;

// The Store class (Subject)
internal class Store : ISubject
{
    private List<IObserver> _customers = new List<IObserver>();
    private List<string> _products = new List<string>();

    public void AddProduct(string product)
    {
        _products.Add(product);
        Console.WriteLine($"Store: {product} is now available.");
        Notify(product);
    }

    public void Subscribe(IObserver observer)
    {
        _customers.Add(observer);
        Console.WriteLine("Store: A customer has subscribed for notifications.");
    }

    public void Unsubscribe(IObserver observer)
    {
        _customers.Remove(observer);
        Console.WriteLine("Store: A customer has unsubscribed from notifications.");
    }

    public void Notify(string product)
    {
        foreach (var customer in _customers)
        {
            customer.Update(product);
        }
    }
}
