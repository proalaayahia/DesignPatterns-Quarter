using StatePattern.Core;

var products = new ProductDataReader().GetProducts();
while (true)
{
    Console.WriteLine("Item List");
    foreach (var item in products)
    {
        Console.WriteLine($"\t{item.Id}.{item.Name} ({item.UnitPrice:0.00})");
    }
    Console.WriteLine();
    var order = new Order();
    Console.WriteLine($"Order State: {order.State}");
    Console.Write("Enter product ID (0 to complete the request):");
    int productId = int.Parse(Console.ReadLine()!);
    if (productId == 0)
    {
        break;
    }
    Console.Write("Enter product quantity:");
    double quantity = double.Parse(Console.ReadLine()!);
    var product = products.First(p => p.Id == productId);
    order.Lines.Add(new OrderLine { ProductId = product.Id, Quantity = quantity, UnitPrice = product.UnitPrice });
    while (true)
    {
        Console.WriteLine("select action:");
        Console.WriteLine("\t1.Confirmed");
        Console.WriteLine("\t2.UnderProcessing");
        Console.WriteLine("\t3.Shipped");
        Console.WriteLine("\t4.Delivered");
        Console.WriteLine("\t5.Returned");
        Console.WriteLine("\t6.Canceled");
        Console.WriteLine("\t0.Exit");
        int action = int.Parse(Console.ReadLine()!);
        try
        {
            if (action == 0)
            {
                break;
            }
            else if (action == 1)
            {
                order.Confirm();
            }
            else if (action == 2)
            {
                order.Process();
            }
            else if (action == 3)
            {
                order.Ship();
            }
            else if (action == 4)
            {
                order.Deliver();
            }
            else if (action == 5)
            {
                order.Rerturn();
            }
            else if (action == 6)
            {
                order.Cancel();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order state changed to `{order.State}`");
            Console.ForegroundColor = ConsoleColor.White;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    Console.WriteLine("---------------------------------------------------------");
}
