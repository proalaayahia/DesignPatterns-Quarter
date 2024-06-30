namespace ChainOfResponsiblityPattern.Core;

internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateOnly DateOfBirth { get; set; }
    public DateOnly HireDate { get; set; }
    public JobTitle JobTitle { get; set; }
    public bool IsTerminated { get; set; }
}
