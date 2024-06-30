namespace DecoratorPattern.Core;

internal class Order
{
    private List<OrderLine> _lines = [];
    public IReadOnlyCollection<OrderLine> Lines => _lines;
    public void AddLine(int itemId, double quantity, decimal unitPrice) => _lines.Add(new OrderLine { ItemId = itemId, Quantity = quantity, UnitPrice = unitPrice });

}
