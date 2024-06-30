using FactoryPattern.Core;
using FactoryPattern.Core.DiscountStrategies;

namespace FactoryPattern;

internal sealed class CustomerDiscountStrategyFactory
{
    public static ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category)
    {
        ICustomerDiscountStrategy strategy = null!;
        switch (category)
        {
            case CustomerCategory.None:
                strategy = new NewCustomerDiscountStrategy();
                break;
            case CustomerCategory.Gold:
                strategy = new GoldCustomerDiscountStrategy();
                break;
            case CustomerCategory.Silver:
                strategy = new SilverCustomerDiscountStrategy();
                break;
        }
        return strategy;
    }
}
