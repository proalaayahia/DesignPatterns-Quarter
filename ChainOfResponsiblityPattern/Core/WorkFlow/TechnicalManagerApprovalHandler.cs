namespace ChainOfResponsiblityPattern.Core.WorkFlow;

internal class TechnicalManagerApprovalHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.TeamLeader ||
            (request.Employee.JobTitle == JobTitle.Developer && request.TotalDays > 3))
        {
            Console.WriteLine("Request has been approved by Technical Manager");
        }
        else
        {
            CallNext(request);
        }
    }
}
