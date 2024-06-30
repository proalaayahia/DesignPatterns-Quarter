﻿namespace StatePattern.Core.States;

internal class OrderReturnedState : IOrderState
{
    private readonly Order _order;
    public OrderReturnedState(Order order)
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
        throw new NotImplementedException();
    }

    public void Ship()
    {
        throw new NotImplementedException();
    }
}
