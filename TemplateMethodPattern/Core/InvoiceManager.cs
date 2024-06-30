using TemplateMethodPattern.Core.DiscountStrategies;

namespace TemplateMethodPattern.Core;

public class InvoiceManager
{
    private ICustomerDiscountStrategy _customerDiscountStrategy;
    public void SetDiscountStrategy(ICustomerDiscountStrategy customerDiscountStrategy)
    {
        _customerDiscountStrategy = customerDiscountStrategy;
    }
    public Invoice CreateInvoice(Customer customer, int quantity, decimal unitPrice)
    {
        var invoice = new Invoice
        {
            Customer = customer,
            Lines = [new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice }]
        };
        invoice.DiscountPercentage = _customerDiscountStrategy.CalcuateDiscount(invoice.TotalPrice);
        return invoice;
    }
}
