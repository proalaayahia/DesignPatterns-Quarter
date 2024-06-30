namespace MementoPattern.Core.MementoSnapshot;

internal class CareTaker
{
    private List<OrderMemento> _mementos = [];
    public int AddMemento(OrderMemento memento)
    {
        _mementos.Add(memento);
        return _mementos.Count - 1;
    }
    public OrderMemento GetMemento(int index) => _mementos[index];
}
