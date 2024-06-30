namespace BuilderPattern;

internal class SalaryCalculator
{
    public SalaryCalculator(int taxPercentage = 0, decimal bonusPercentage = 0, decimal educationPackage = 0, decimal transportation = 0,
        bool sendPaysLipToEmployee = true, bool postResultsToGL = true)
    {
        TaxPercentage = taxPercentage;
        BonusPercentage = bonusPercentage;
        EducationPackage = educationPackage;
        Transportation = transportation;
        SendPaysLipToEmployee = sendPaysLipToEmployee;
        PostResultsToGL = postResultsToGL;
    }

    public int TaxPercentage { get; }
    public decimal BonusPercentage { get; }
    public decimal EducationPackage { get; }
    public decimal Transportation { get; }
    public bool SendPaysLipToEmployee { get; }
    public bool PostResultsToGL { get; }
    public decimal Calculate(Employee employee)
    {
        var bonus = employee.BasicSalary * BonusPercentage / 100;
        var taxes = employee.BasicSalary * TaxPercentage / 100;
        var salary = employee.BasicSalary + EducationPackage + Transportation + bonus - taxes;
        Console.ForegroundColor = ConsoleColor.Green;
        if (SendPaysLipToEmployee)
        {
            Console.WriteLine($"PaysLip has been sent to `{employee.Email}`");
        }
        if (PostResultsToGL)
        {
            Console.WriteLine($"Salary voucher with total amount ({salary} EGP) has been sent to GL");
        }
        Console.ForegroundColor = ConsoleColor.White;
        return salary!;
    }
}
