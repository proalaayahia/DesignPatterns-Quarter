namespace FacadePattern.Core;
public class OrderService
{
    public bool HasEnoughOrders(int customerId) => (customerId > 5);
}
