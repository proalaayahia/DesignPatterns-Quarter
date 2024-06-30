namespace StrategyPattern.Core.DiscountStrategies;

public interface ICustomerDiscountStrategy
{
    decimal CalcuateDiscount(decimal totalPrice);
}
