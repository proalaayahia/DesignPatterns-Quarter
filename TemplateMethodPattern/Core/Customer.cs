namespace TemplateMethodPattern.Core;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public CustomerCategory Category { get; set; }
}