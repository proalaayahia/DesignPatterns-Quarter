namespace BuilderPattern;

internal class SalaryCalculatorBuilder
{
    int _taxPercentage = 0;
    decimal _bonusPercentage = 0;
    decimal _educationPackage = 0;
    decimal _transportation = 0;
    bool _sendPaysLipToEmployee = true;
    bool _postResultsToGL = true;
    public SalaryCalculatorBuilder WithTaxes(int percentage)
    {
        LogMessage($"{percentage}% taxes will be deducted.");
        _taxPercentage = percentage;
        return this;
    }
    public SalaryCalculatorBuilder WithBonus(decimal percentage)
    {
        LogMessage($"{percentage}% bonus will be added.");
        _bonusPercentage = percentage;
        return this;
    }
    public SalaryCalculatorBuilder WithEducation(decimal package)
    {
        LogMessage($"{package} EGP education package will be added.");
        _educationPackage = package;
        return this;
    }
    public SalaryCalculatorBuilder WithTransportation(decimal value)
    {
        LogMessage($"{value} EGP transportaion will be added.");
        _transportation = value;
        return this;
    }
    public SalaryCalculatorBuilder SendPayLipsToEmployee(bool send)
    {
        _sendPaysLipToEmployee = send;
        return this;
    }
    public SalaryCalculatorBuilder PostResultsToGL(bool post)
    {
        _postResultsToGL = post;
        return this;
    }
    private void LogMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public SalaryCalculator Build() => new SalaryCalculator(_taxPercentage, _bonusPercentage, _educationPackage,
        _transportation, _sendPaysLipToEmployee, _postResultsToGL);
}
