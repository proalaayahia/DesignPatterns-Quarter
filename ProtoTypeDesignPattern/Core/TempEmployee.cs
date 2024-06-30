namespace ProtoTypeDesignPattern.Core;

internal class TempEmployee : EmployeePrototype
{
    public override EmployeePrototype DeepClone()
    {
        TempEmployee employee = new();
        employee = (TempEmployee)this.MemberwiseClone();
        employee.Address = new Address { Building = Address.Building, City = Address.City, StreetName = Address.StreetName };
        employee.Name = Name;
        return employee;
    }

    public override EmployeePrototype ShallowClone()
    {
        return (TempEmployee)this.MemberwiseClone();
    }
}
