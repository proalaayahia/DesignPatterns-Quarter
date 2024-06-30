using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShopingCarts;

internal abstract class ShoppingCart
{
    private List<InvoiceLine> _lines = [];
    public void AddItem(int id, int quantity, decimal unitPrice)
    {
        _lines.Add(new InvoiceLine { ItemId = id, Quantity = quantity, UnitPrice = unitPrice });
    }
    //template method
    public void CheckOut(Customer customer)
    {
        var invoice = new Invoice { Customer = customer, Lines = _lines };
        ApplyTaxes(invoice);
        ApplyDiscount(invoice);
        ProcessPayment(invoice);
    }

    public void ProcessPayment(Invoice invoice)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{GetType().Name} Invoice created for customer `{invoice.Customer.Name}` with net price = {invoice.NetPrice}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    protected abstract void ApplyDiscount(Invoice invoice);

    public void ApplyTaxes(Invoice invoice)
    {
        invoice.Taxes = invoice.TotalPrice * 0.15m;
    }
}
