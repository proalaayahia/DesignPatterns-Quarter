namespace AbstractFactoryPattern.Core;

/// ConcreteProduct
public class ShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 20;
}
