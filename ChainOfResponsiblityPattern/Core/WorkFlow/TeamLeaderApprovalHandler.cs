namespace ChainOfResponsiblityPattern.Core.WorkFlow;

internal class TeamLeaderApprovalHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.Developer && request.TotalDays <= 3)
        {
            Console.WriteLine("Request has been approved by TeamLeader");
        }
        else
        {
            CallNext(request);
        }
    }
}
