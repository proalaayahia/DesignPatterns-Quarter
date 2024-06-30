namespace MementoPattern.Core.MementoSnapshot;

internal class OrderMemento
{
    private readonly IEnumerable<OrderLine> _lines;

    public OrderMemento(IEnumerable<OrderLine> lines)
    {
        _lines = lines;
    }
    public IEnumerable<OrderLine> GetLines() => _lines;
}
