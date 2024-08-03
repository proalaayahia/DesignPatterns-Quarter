namespace ObserverPattern.Core;

// The Customer class (Observer)
internal class Customer : IObserver
{
    private string _name;
    private string _interestedProduct;

    public Customer(string name, string interestedProduct)
    {
        _name = name;
        _interestedProduct = interestedProduct;
    }

    public void Update(string product)
    {
        if (product == _interestedProduct)
        {
            Console.WriteLine($"Customer {_name}: Hurray! The {_interestedProduct} is now available at the store.");
        }
    }
}
