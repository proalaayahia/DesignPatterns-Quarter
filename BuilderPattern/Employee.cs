namespace BuilderPattern
{
    public class Employee
    {
        public Employee(string name, string email, decimal basicSalary)
        {
            Name = name;
            Email = email;
            BasicSalary = basicSalary;
        }
        public decimal BasicSalary { get; internal set; }
        public string Email { get; internal set; } = null!;
        public string Name { get; internal set; } = null!;
    }
}