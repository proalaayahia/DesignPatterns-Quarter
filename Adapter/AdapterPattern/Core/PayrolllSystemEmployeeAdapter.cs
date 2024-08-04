namespace AdapterPattern.Core;

public class PayrolllSystemEmployeeAdapter
{
    private readonly Employee _employee;
    private readonly IEnumerable<PayrolllSystemPayItemAdapter> _payrolllSystemPayItems;
    public PayrolllSystemEmployeeAdapter(Employee employee)
    {
        _employee = employee;
        _payrolllSystemPayItems = _employee.PayItems.Select(payItem => new PayrolllSystemPayItemAdapter(payItem));
    }

    public string FullName => _employee.FullName;
    public IEnumerable<PayrolllSystemPayItemAdapter> PayItems => _payrolllSystemPayItems;
}
