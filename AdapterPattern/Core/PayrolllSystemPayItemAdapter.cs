namespace AdapterPattern.Core;

public class PayrolllSystemPayItemAdapter
{
    private readonly PayItem _payItem;

    public PayrolllSystemPayItemAdapter(PayItem payItem)
    {
        _payItem = payItem;
    }
    public string Name => _payItem.Name;
    public decimal Value => _payItem.IsDeduction ? _payItem.Value * -1 : _payItem.Value;
}
