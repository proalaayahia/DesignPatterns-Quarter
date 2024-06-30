namespace StatePattern.Core;

internal class ProductDataReader
{
    public IEnumerable<Product> GetProducts() =>
        [
        new Product { Id=1,Name="LCD",UnitPrice=2000},
        new Product { Id=2,Name="Laptop",UnitPrice=10000},
        new Product { Id=3,Name="Keyboard",UnitPrice=200},
        new Product { Id=4,Name="Mouse",UnitPrice=100}
    ];
}
