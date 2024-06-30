using AbstractFactoryPattern.Core;

var egyptShoppingCartPurchaseFactory = new ShoppingCartPurchaseFactory();
var shoppingCartForEgypt = new ShoppingCart(egyptShoppingCartPurchaseFactory);
shoppingCartForEgypt.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

Console.ReadKey();