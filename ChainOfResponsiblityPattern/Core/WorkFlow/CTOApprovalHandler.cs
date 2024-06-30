namespace ChainOfResponsiblityPattern.Core.WorkFlow;

internal class CTOApprovalHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.TechnicalManager)
        {
            Console.WriteLine("Request has been approved by CTO");
        }
        else
        {
            CallNext(request);
        }
    }
}
