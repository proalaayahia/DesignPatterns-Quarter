using DecoratorPattern.Core;

var order = new Order();
order.AddLine(1, 5, 1000);
order.AddLine(2, 3, 2000);
order.AddLine(3, 4, 1500);

IOrderProcessor processor = new OrderProcessor();
processor = new OrderProcessorExceptionHandlingDecorator(processor);
processor = new OrderProcessorExceptionHandlingDecorator(processor);
processor = new OrderProcessorProfilingDecorator(processor);
processor.Process(order);
Console.ReadKey();