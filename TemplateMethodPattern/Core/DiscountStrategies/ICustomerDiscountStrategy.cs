namespace TemplateMethodPattern.Core.DiscountStrategies;

public interface ICustomerDiscountStrategy
{
    decimal CalcuateDiscount(decimal totalPrice);
}
