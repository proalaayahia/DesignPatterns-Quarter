namespace MediatorPattern.Core;

public class AirTrafficControl : IAirTrafficControl
{
    private readonly List<Aircraft> _aircrafts = new List<Aircraft>();

    public void RegisterAircraft(Aircraft aircraft)
    {
        _aircrafts.Add(aircraft);
    }

    public void SendMessage(string message, Aircraft aircraft)
    {
        foreach (var a in _aircrafts)
        {
            // Don't send the message to the sender aircraft
            if (a != aircraft)
            {
                a.ReceiveMessage(message);
            }
        }
    }
}
