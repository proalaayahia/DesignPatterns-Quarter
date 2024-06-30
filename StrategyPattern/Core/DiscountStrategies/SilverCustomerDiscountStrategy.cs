namespace StrategyPattern.Core.DiscountStrategies;

public class SilverCustomerDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalcuateDiscount(decimal totalPrice)
    {
        return totalPrice >= 10000 ? 0.05m : 0;
    }
}
