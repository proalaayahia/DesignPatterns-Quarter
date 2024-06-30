namespace FactoryPattern.Core;

public class CustomerDataReader
{
    public IEnumerable<Customer> GetCustomers()
    {
        return [
            new Customer{
                Id = 1,
                Name="Ahmed Thabet",
                Category=CustomerCategory.None
            },
            new Customer{
                Id = 2,
                Name="Ahmed Khalaf",
                Category=CustomerCategory.Gold
            },
            new Customer{
                Id = 3,
                Name="Mina Girgis",
                Category=CustomerCategory.Silver
            },
            ];
    }
}
