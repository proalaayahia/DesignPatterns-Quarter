namespace ProtoTypeDesignPattern.Core;

internal class RegularEmployee : EmployeePrototype
{
    public override EmployeePrototype DeepClone()
    {
        RegularEmployee employee = new();
        employee = (RegularEmployee)this.MemberwiseClone();
        employee.Address = new Address { Building = Address.Building, City = Address.City, StreetName = Address.StreetName };
        employee.Name = Name;
        return employee;
    }

    public override EmployeePrototype ShallowClone()
    {
        return (RegularEmployee)this.MemberwiseClone();
    }
}
