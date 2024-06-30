using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShopingCarts;

internal class InStoreShoppingCart : ShoppingCart
{
    protected override void ApplyDiscount(Invoice invoice)
    {
        return;
    }
}
