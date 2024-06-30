namespace ObserverPattern.Core;
public class TicketChange
{
    public int Amount { get; private set; }
    public int ArtistId { get; private set; }

    public TicketChange(int artistId, int amount)
    {
        ArtistId = artistId;
        Amount = amount;
    }
}
