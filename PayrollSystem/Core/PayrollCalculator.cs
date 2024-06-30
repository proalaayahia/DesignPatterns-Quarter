﻿using System.Diagnostics;

namespace PayrollSystem.Core;

public class PayrollCalculator
{
    public decimal Calculate(Employee employee)
    {
        Debug.WriteLine($"calculating salary for employee `{employee.FullName}`");
        if (!employee.PayItems.Any())
        {
            return 0;
        }
        var monthTotal = employee.PayItems.Sum(payItem => payItem.Value);
        return Math.Round(monthTotal / DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * DateTime.Today.Day, 2);
    }
}