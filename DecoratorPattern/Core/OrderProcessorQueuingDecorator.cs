namespace DecoratorPattern.Core;

internal class OrderProcessorQueuingDecorator : IOrderProcessor
{
    private readonly IOrderProcessor _processor;
    private Queue<Order> _orders = [];
    public OrderProcessorQueuingDecorator(IOrderProcessor processor)
    {
        _processor = processor;
    }
    public void Process(Order order)
    {
        _orders.Enqueue(order);
        Console.WriteLine($"Order has been queued.");
    }
}
