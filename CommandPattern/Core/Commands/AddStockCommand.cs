namespace CommandPattern.Core.Commands;

internal class AddStockCommand : ICommand
{
    private readonly Product _product;
    private readonly double _quantity;

    public AddStockCommand(Product product, double quantity)
    {
        _product = product;
        _quantity = quantity;
    }
    public void Execute()
    {
        _product.AddStock(_quantity);
    }

    public void Undo()
    {
        _product.AddStock(_quantity * -1);
    }
}
