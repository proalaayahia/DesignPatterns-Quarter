using CommandPattern.Core;
using CommandPattern.Core.Commands;
using CommandPattern.Core.Macros;

var laptop = new Product(1, "Laptop", 10000, 50);
var keyboard = new Product(1, "Keyboard", 300, 30);
var mouse = new Product(1, "Mouse", 200, 20);

while (true)
{
    var order = new Order();
    var invoker = new CommandInvoker();
    while (true)
    {
        Console.WriteLine("Select one of the bellow commands:");
        Console.WriteLine("\t1. add laptop");
        Console.WriteLine("\t2. add keyboard");
        Console.WriteLine("\t3. add mouse");
        Console.WriteLine("\t4. save macro");
        Console.WriteLine("\t5. replay macro");
        Console.WriteLine("\t6. undo");
        Console.WriteLine("\t7. redo");
        Console.WriteLine("\t0. process");
        var commandId = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        double quantity = 0;
        if (commandId != 0 && commandId != 4 && commandId != 5 && commandId != 6 && commandId != 7)
        {
            Console.Write("enter required quantity: ");
            quantity = double.Parse(Console.ReadLine()!);
        }
        if (commandId == 0)
        {
            invoker.ExecuteCommands();
            var totalQuantity = order.Lines.Sum(x => x.Quantity);
            var totalPrice = order.Lines.Sum(x => x.Quantity * x.UnitPrice);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order #{order.Id}, Quantity = {totalQuantity} and Total Price = {totalPrice:0.00}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (commandId == 1)
        {
            invoker.ExecuteCommand(new AddProductCommand(order, laptop, quantity));
            invoker.ExecuteCommand(new AddStockCommand(laptop, -1));
        }
        else if (commandId == 2)
        {
            invoker.ExecuteCommand(new AddProductCommand(order, keyboard, quantity));
            invoker.ExecuteCommand(new AddStockCommand(keyboard, -1));
        }
        else if (commandId == 3)
        {
            invoker.ExecuteCommand(new AddProductCommand(order, mouse, quantity));
            invoker.ExecuteCommand(new AddStockCommand(mouse, -1));
        }
        else if (commandId == 4)
        {
            var commands = new List<ICommand>(invoker.Commands);
            MacroStorage.Instance.CreateMacro(commands);
            invoker.ClearCommands();
        }
        else if (commandId == 5)
        {
            ReplayMacro();
        }
        else if (commandId == 6)
        {
            invoker.Undo();
            invoker.Undo();
            var totalQuantity = order.Lines.Sum(x => x.Quantity);
            var totalPrice = order.Lines.Sum(x => x.Quantity * x.UnitPrice);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Order #{order.Id}, Quantity = {totalQuantity} and Total Price = {totalPrice:0.00}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (commandId == 7)
        {
            invoker.Redo();
            invoker.Redo();
            var totalQuantity = order.Lines.Sum(x => x.Quantity);
            var totalPrice = order.Lines.Sum(x => x.Quantity * x.UnitPrice);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Order #{order.Id}, Quantity = {totalQuantity} and Total Price = {totalPrice:0.00}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine("---------------------------------------------------");
    }
}

void ReplayMacro()
{
    Console.WriteLine("Enter macro ID:");
    foreach (Macro macro in MacroStorage.Instance.GetMacros())
    {
        Console.WriteLine($"\t{macro.Id}. (commands count= {macro.Commands.Count()}, created at: {macro.CreatedAt})");
    }
    var macroId = int.Parse(Console.ReadLine()!);
    var selectedMacro = MacroStorage.Instance.GetMacro(macroId);
    var order = new Order();
    var invoker = new CommandInvoker();
    foreach (var command in selectedMacro.Commands)
    {
        if (command is AddProductCommand addProductCommand)
        {
            addProductCommand.Order = order;
        }
        invoker.AddCommand(command);
    }
    invoker.ExecuteCommands();
}