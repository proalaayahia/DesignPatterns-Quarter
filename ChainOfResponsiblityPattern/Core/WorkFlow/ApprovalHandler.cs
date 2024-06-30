namespace ChainOfResponsiblityPattern.Core.WorkFlow;

internal abstract class ApprovalHandler : IApprovalHandler
{
    private IApprovalHandler _next = null!;

    public abstract void Process(VacationRequest request);

    public void SetNextHandler(IApprovalHandler next)
    {
        _next = next;
    }
    protected void CallNext(VacationRequest request)
    {
        if (_next != null)
        {
            _next.Process(request);
        }
    }
}
