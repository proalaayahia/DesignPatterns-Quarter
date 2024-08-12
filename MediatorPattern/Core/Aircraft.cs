
namespace MediatorPattern.Core;
public abstract class Aircraft
{
    protected IAirTrafficControl _atc;
    public string CallSign { get; private set; }

    protected Aircraft(IAirTrafficControl atc, string callSign)
    {
        _atc = atc;
        CallSign = callSign;
        _atc.RegisterAircraft(this);
    }

    public abstract void Send(string message);
    public abstract void ReceiveMessage(string message);
}
