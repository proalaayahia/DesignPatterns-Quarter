namespace StatePattern.Core.States;

internal interface IOrderState
{
    void Confirm();
    void Cancel();
    void Process();
    void Ship();
    void Return();
    void Deliver();
}
