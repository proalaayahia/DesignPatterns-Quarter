namespace TemplateMethodPattern.Core.DiscountStrategies;

public class NewCustomerDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalcuateDiscount(decimal totalPrice)
    {
        return 0;
    }
}
