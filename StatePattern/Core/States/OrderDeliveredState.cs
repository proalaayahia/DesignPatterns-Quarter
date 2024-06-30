namespace StatePattern.Core.States;

internal class OrderDeliveredState : IOrderState
{
    private readonly Order _order;
    public OrderDeliveredState(Order order)
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
        throw new NotImplementedException();
    }

    public void Process()
    {
        throw new NotImplementedException();
    }

    public void Return()
    {
        _order.State = new OrderReturnedState(_order);
    }

    public void Ship()
    {
        throw new NotImplementedException();
    }
}
