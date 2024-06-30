namespace DecoratorPattern.Core;

internal class OrderProcessor : IOrderProcessor
{
    public void Process(Order order)
    {
        if (order.Lines.Count == 0)
            throw new Exception("Order lines is empty.");
        //simulation
        Thread.Sleep(Random.Shared.Next(1000, 3000));
        Console.WriteLine("order has been processed");
    }
}
