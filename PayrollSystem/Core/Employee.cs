namespace PayrollSystem.Core;
public record Employee(string FullName, IEnumerable<PayItem> PayItems);