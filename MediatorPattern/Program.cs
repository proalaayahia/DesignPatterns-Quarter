using MediatorPattern.Core;

IAirTrafficControl atc = new AirTrafficControl();

Aircraft flightA = new CommercialAircraft(atc, "Flight A");
Aircraft flightB = new PrivateAircraft(atc, "Flight B");
Aircraft flightC = new CommercialAircraft(atc, "Flight C");

flightA.Send("Requesting permission to land.");
flightB.Send("Taxiing to the runway.");
flightC.Send("Ready for takeoff.");
