using ChainOfResponsiblityPattern.Core;
using ChainOfResponsiblityPattern.Core.WorkFlow;

var employee = new Employee
{
    Id = 1,
    Name = "Abdo Adel",
    DateOfBirth = new DateOnly(1996, 7, 20),
    HireDate = new DateOnly(2016, 1, 1),
    JobTitle = JobTitle.Developer
};
var request = new VacationRequest
{
    Employee = employee,
    StartDate = DateTime.Today.AddDays(5),
    EndDate = DateTime.Today.AddDays(2)
};
var validation = new RequestDaysValidationHandler();
var teamLeaderHandler = new TeamLeaderApprovalHandler();
var technicalManagerHandler = new TechnicalManagerApprovalHandler();
var CTOHandler = new CTOApprovalHandler();
var CEOHandler = new CEOApprovalHandler();
validation.SetNextHandler(teamLeaderHandler);
teamLeaderHandler.SetNextHandler(technicalManagerHandler);
technicalManagerHandler.SetNextHandler(CTOHandler);
CTOHandler.SetNextHandler(CEOHandler);

validation.Process(request);