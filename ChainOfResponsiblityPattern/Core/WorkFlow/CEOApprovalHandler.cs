namespace ChainOfResponsiblityPattern.Core.WorkFlow;

internal class CEOApprovalHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.CTO)
        {
            Console.WriteLine("Request has been approved by CEO");
        }
        else
        {
            CallNext(request);
        }
    }
}
