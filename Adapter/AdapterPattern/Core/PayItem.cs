namespace AdapterPattern.Core;
//business case to store all pay item value in database with positive values so we have to make adapter for pay item and employee
public record PayItem(string Name, decimal Value, bool IsDeduction = false);