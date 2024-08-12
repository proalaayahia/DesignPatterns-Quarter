
namespace MediatorPattern.Core;
public class CommercialAircraft : Aircraft
{
    public CommercialAircraft(IAirTrafficControl atc, string callSign)
        : base(atc, callSign)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{CallSign} (Commercial) sends message: {message}");
        _atc.SendMessage(message, this);
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"{CallSign} (Commercial) received message: {message}");
    }
}
