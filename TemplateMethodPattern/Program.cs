using TemplateMethodPattern.Core;
using TemplateMethodPattern.ShopingCarts;
//here we have stategy pattern and null object pattern
var customerDataReader = new CustomerDataReader();
var itemDataReader = new ItemDataReader();
var customers = customerDataReader.GetCustomers();
var items = itemDataReader.GetItems();
while (true)
{
    Console.WriteLine("Customers list:");
    foreach (var c in customers)
    {
        Console.WriteLine($"\t{c.Id}- {c.Name} ({c.Category})");
    }
    Console.WriteLine();
    Console.WriteLine("Items list:");
    foreach (var item in items)
    {
        Console.WriteLine($"\t{item.Id}- {item.Name} ({item.UnitPrice:0.00})");
    }
    Console.WriteLine();
    Console.Write("Enter customer ID: ");
    int id = int.Parse(Console.ReadLine()!);
    Console.Write("Select Shopping Cart Type ( Online | InStore )? ");
    ShoppingCart shoppingCart = Console.ReadLine()!
        .Equals("Online", StringComparison.OrdinalIgnoreCase) ? new OnlineShoppingCart() : new InStoreShoppingCart();
    while (true)
    {
        Console.Write("Enter item ID(0 to complete the order): ");
        int itemId = int.Parse(Console.ReadLine()!);
        if (itemId == 0)
        {
            break;
        }
        Console.Write("Enter Item Quantity? ");
        int quantity = int.Parse(Console.ReadLine()!);
        var item = items.First(x => x.Id == itemId);
        shoppingCart.AddItem(itemId, quantity, item.UnitPrice);
    }
    var selectedCustomer = customers.First(x => x.Id == id);
    shoppingCart.CheckOut(selectedCustomer);
    Console.WriteLine("============================================================");
}