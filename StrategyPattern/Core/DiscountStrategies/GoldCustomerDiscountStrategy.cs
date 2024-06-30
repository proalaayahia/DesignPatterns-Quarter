namespace StrategyPattern.Core.DiscountStrategies;

public class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalcuateDiscount(decimal totalPrice)
    {
        return totalPrice >= 10000 ? 0.1m : 0;
    }
}
