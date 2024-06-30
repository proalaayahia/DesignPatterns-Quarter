namespace ChainOfResponsiblityPattern.Core;

internal class VacationRequest
{
    public Employee Employee { get; set; } = new();
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double TotalDays => EndDate.Subtract(StartDate).TotalDays;
}