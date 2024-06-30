namespace AbstractFactoryPattern.Core;

/// ConcreteProduct
public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}
