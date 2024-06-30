using BuilderPattern;

var builder = new SalaryCalculatorBuilder();
builder.WithTaxes(10).WithBonus(20).WithTransportation(5);
while (true)
{
    Console.WriteLine("Select an option:");
    Console.WriteLine("1. Add 20% bonus");
    Console.WriteLine("2. Deduct 10% taxes");
    Console.WriteLine("3. Add 2000 education package");
    Console.WriteLine("4. Add 1000 transportation");
    Console.WriteLine("5. Send payslip to employee");
    Console.WriteLine("6. Post voucher to GL");
    Console.WriteLine("*. Build");
    var option = int.Parse(Console.ReadLine()!);
    if (option == 1)
    {
        builder.WithBonus(20);
    }
    else if (option == 2)
    {
        builder.WithTaxes(10);
    }
    else if (option == 3)
    {
        builder.WithEducation(2000);
    }
    else if (option == 4)
    {
        builder.WithTransportation(1000);
    }
    else if (option == 5)
    {
        builder.SendPayLipsToEmployee(true);
    }
    else if (option == 6)
    {
        builder.PostResultsToGL(true);
    }
    else
    {
        var calculator = builder.Build();
        var employee = new Employee("Esam Adel", "esam.adel@test.com", 20000);
        var salary = calculator.Calculate(employee);
        Console.ReadKey();
        builder = new SalaryCalculatorBuilder();
    }
}