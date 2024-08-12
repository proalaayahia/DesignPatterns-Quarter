
namespace MediatorPattern.Core;
public class PrivateAircraft : Aircraft
{
    public PrivateAircraft(IAirTrafficControl atc, string callSign)
        : base(atc, callSign)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{CallSign} (Private) sends message: {message}");
        _atc.SendMessage(message, this);
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"{CallSign} (Private) received message: {message}");
    }
}
