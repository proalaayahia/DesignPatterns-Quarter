namespace AbstractFactoryPattern.Core;

public class ShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new DiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new ShippingCostsService();
    }
}
