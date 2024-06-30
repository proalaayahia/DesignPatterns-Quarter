using FactoryPattern;
using FactoryPattern.Core;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    Console.WriteLine("Customer list [1] Emad Hamdy [2] Ahmed Khalaf [3] Mina Girgis");
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
    var strategy = CustomerDiscountStrategyFactory.CreateCustomerDiscountStrategy(customer.Category);
    var manager = new InvoiceManager();
    manager.SetDiscountStrategy(strategy);
    var invoice = manager.CreateInvoice(customer, quantity, price);
    Console.WriteLine($"invoice created for customer `{customer.Name}` with net price = {invoice.NetPrice} ");
}