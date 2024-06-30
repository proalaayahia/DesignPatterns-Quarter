using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShopingCarts;

internal class OnlineShoppingCart : ShoppingCart
{
    protected override void ApplyDiscount(Invoice invoice)
    {
        if (invoice.TotalPrice >= 10000)
        {
            invoice.DiscountPercentage = 0.05m;
        }
    }
}
