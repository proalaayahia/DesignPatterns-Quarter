namespace ObserverPattern.Core;

/// Observer
public interface ITicketChangeListener
{
    void ReceiveTicketChangeNotification(TicketChange ticketChange);
}
