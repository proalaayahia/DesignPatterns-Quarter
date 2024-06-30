namespace CommandPattern.Core;

internal class Order
{
    public int Id { get; } = Random.Shared.Next(1, 1000);
    private List<OrderLine> _lines = [];
    public IReadOnlyCollection<OrderLine> Lines => _lines;
    public void AddProduct(Product product, double quantity)
    {
        _lines.Add(new OrderLine(product.Id, quantity, product.UnitPrice));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Product `{product.Name}` added, order now contains {_lines.Count} products.");
        Console.ForegroundColor = ConsoleColor.White;
    }

    internal void RemoveProductAt(int index)
    {
        _lines.RemoveAt(index);
    }
}
