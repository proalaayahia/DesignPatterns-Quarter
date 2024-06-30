namespace AbstractFactoryPattern.Core;

/// ConcreteProduct
public class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 25;
}
