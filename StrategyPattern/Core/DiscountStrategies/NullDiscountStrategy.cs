namespace StrategyPattern.Core.DiscountStrategies;

internal class NullDiscountStrategy : ICustomerDiscountStrategy
{
    public decimal CalcuateDiscount(decimal totalPrice)
    {
        return 0;
    }
}
