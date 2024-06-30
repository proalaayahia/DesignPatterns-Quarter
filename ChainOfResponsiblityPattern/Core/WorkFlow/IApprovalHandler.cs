namespace ChainOfResponsiblityPattern.Core.WorkFlow;

internal interface IApprovalHandler
{
    void SetNextHandler(IApprovalHandler next);
    void Process(VacationRequest request);
}
