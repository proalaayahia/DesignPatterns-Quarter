using StatePattern.Core.States;

namespace StatePattern.Core;

internal class Order
{
    public Order()
    {
        State = new OrderDraftState(this);
    }
    public IOrderState State { get; internal set; }
    public List<OrderLine> Lines { get; set; } = [];
    //public void SetState(OrderState newState)
    //{
    //    bool IsValid = (State == OrderState.Draft && newState != OrderState.Confirmed) ||
    //         (State == OrderState.Confirmed && newState != OrderState.Canceled && newState != OrderState.UnderProcessing) ||
    //         (State == OrderState.UnderProcessing && newState != OrderState.Shipped) ||
    //         (State == OrderState.Shipped && newState != OrderState.Delivered) ||
    //         (State == OrderState.Delivered && newState != OrderState.Returned);
    //    if (IsValid)
    //    {
    //        throw new InvalidOperationException($"Moving from state `{State}` to state `{newState}` is not supported.");
    //    }
    //    else
    //    {
    //        State = newState;
    //    }
    //}
    public void Confirm() => State.Confirm();
    public void Cancel() => State.Cancel();
    public void Deliver() => State.Deliver();
    public void Rerturn() => State.Return();
    public void Process() => State.Process();
    public void Ship() => State.Ship();
}
