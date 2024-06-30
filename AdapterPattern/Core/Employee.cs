namespace AdapterPattern.Core;
public record Employee(string FirstName, string LastName, IEnumerable<PayItem> PayItems)
{
    public string FullName => $"{FirstName} {LastName}";
}