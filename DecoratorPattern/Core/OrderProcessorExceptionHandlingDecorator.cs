namespace DecoratorPattern.Core;

internal class OrderProcessorExceptionHandlingDecorator : IOrderProcessor
{
    private readonly IOrderProcessor _processor;
    public OrderProcessorExceptionHandlingDecorator(IOrderProcessor processor)
    {
        _processor = processor;
    }
    public void Process(Order order)
    {
        try
        {

            _processor.Process(order);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
