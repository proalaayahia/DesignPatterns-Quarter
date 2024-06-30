using System.Diagnostics;

namespace DecoratorPattern.Core;

internal class OrderProcessorProfilingDecorator : IOrderProcessor
{
    private readonly IOrderProcessor _processor;

    public OrderProcessorProfilingDecorator(IOrderProcessor processor)
    {
        _processor = processor;
    }
    public void Process(Order order)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        _processor.Process(order);
        stopWatch.Stop();
        Console.WriteLine($"Order took `{stopWatch.Elapsed.TotalSeconds}s` to be processed.");
    }
}
