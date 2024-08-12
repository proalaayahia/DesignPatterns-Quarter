namespace MediatorPattern.Core;

public interface IAirTrafficControl
{
    void RegisterAircraft(Aircraft aircraft);
    void SendMessage(string message, Aircraft aircraft);
}
