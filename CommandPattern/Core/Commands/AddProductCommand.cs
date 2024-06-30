namespace CommandPattern.Core.Commands;

internal class AddProductCommand : ICommand
{
    public Order Order { get; set; }
    private readonly Product _product;
    private readonly double _quantity;

    public AddProductCommand(Order order, Product product, double quantity)
    {
        Order = order;
        _product = product;
        _quantity = quantity;
    }
    public void Execute()
    {
        Order.AddProduct(_product, _quantity);
    }

    public void Undo()
    {
        Order.RemoveProductAt(Order.Lines.Count - 1);
    }
}
