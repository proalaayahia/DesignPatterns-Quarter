namespace CommandPattern.Core;

internal class OrderLine
{
    public OrderLine(int productId, double quantity, double unitPrice)
    {
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
    public int ProductId { get; private set; }
    public double Quantity { get; private set; }
    public double UnitPrice { get; private set; }
}
