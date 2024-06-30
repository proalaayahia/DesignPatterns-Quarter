namespace ChainOfResponsiblityPattern.Core.WorkFlow;

internal class RequestDaysValidationHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.TotalDays < 1)
        {
            Console.WriteLine("invalid days!");
        }
        else
        {
            CallNext(request);
        }
    }
}
