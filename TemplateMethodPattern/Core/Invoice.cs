namespace TemplateMethodPattern.Core;

public class Invoice
{
    public Customer Customer { get; set; } = new();
    public IEnumerable<InvoiceLine> Lines { get; set; } = [];
    public decimal TotalPrice => Lines.Sum(line => line.Quantity * line.UnitPrice);
    public decimal DiscountPercentage { get; set; }
    public decimal NetPrice => TotalPrice - TotalPrice * DiscountPercentage;
    public decimal Taxes { get; internal set; }
}
