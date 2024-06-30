namespace ProtoTypeDesignPattern.Core;

internal abstract class EmployeePrototype
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public Address Address { get; set; } = new();
    public abstract EmployeePrototype ShallowClone();
    public abstract EmployeePrototype DeepClone();
    public override string ToString()
    {
        return $@"  
        Id: {Id},
        Name: {Name}
        Address: {Address.City},{Address.StreetName},{Address.Building}";
    }
}
