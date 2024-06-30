namespace StatePattern.Core.States;

internal class OrderShippedState : IOrderState
{
    private readonly Order _order;

    public OrderShippedState(Order order)
    {
        _order = order;
    }

    public void Cancel()
    {
        throw new NotImplementedException();
    }

    public void Confirm()
    {
        throw new NotImplementedException();
    }

    public void Deliver()
    {
        _order.State = new OrderDeliveredState(_order);
    }

    public void Process()
    {
        throw new NotImplementedException();
    }

    public void Return()
    {
        throw new NotImplementedException();
    }

    public void Ship()
    {
        throw new NotImplementedException();
    }
}
