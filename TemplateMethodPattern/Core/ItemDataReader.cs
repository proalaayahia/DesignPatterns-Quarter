namespace TemplateMethodPattern.Core;

internal class ItemDataReader
{
    public IEnumerable<Item> GetItems()
    {
        return [
            new Item{Id=1,Name="Laptop",UnitPrice=10000},
            new Item{Id=2,Name="LCD",UnitPrice=5000},
            new Item{Id=3,Name="Keyboard",UnitPrice=400},
            new Item{Id=4,Name="Mouse",UnitPrice=300}
            ];
    }
}
