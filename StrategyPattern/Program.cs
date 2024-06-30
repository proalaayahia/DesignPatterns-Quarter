using StrategyPattern.Core;
using StrategyPattern.Core.DiscountStrategies;
//here we have stategy pattern and null object pattern
var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    Console.WriteLine("Customer list [1] Ahmed Thabet [2] Ahmed Khalaf [3] Mina Girgis");
    Console.Write("Enter customer ID: ");
    int id = int.Parse(Console.ReadLine()!);
    Console.Write("Enter item quantity: ");
    int quantity = int.Parse(Console.ReadLine()!);
    Console.Write("Enter unit price: ");
    decimal price = decimal.Parse(Console.ReadLine()!);
    var customer = customers.FirstOrDefault(x => x.Id == id);
    if (customer is null)
    {
        Console.WriteLine("customer not found!");
        break;
    }
    ICustomerDiscountStrategy strategy = null!;
    switch (customer.Category)
    {
        case CustomerCategory.None:
            strategy = new NewCustomerDiscountStrategy();
            break;
        case CustomerCategory.Gold:
            strategy = new GoldCustomerDiscountStrategy();
            break;
        case CustomerCategory.Silver:
            strategy = new SilverCustomerDiscountStrategy();
            break;
        default:
            strategy = new NullDiscountStrategy();
            break;
    }
    var manager = new InvoiceManager();
    manager.SetDiscountStrategy(strategy);
    var invoice = manager.CreateInvoice(customer, quantity, price);
    Console.WriteLine($"invoice created for customer `{customer.Name}` with net price = {invoice.NetPrice} ");
}