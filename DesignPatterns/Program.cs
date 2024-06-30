using SingletonPattern;

Console.WriteLine("*********************Singleton**********************");
while (true)
{
    Console.Write("Enter Base Currency: ");
    var baseCurrency = Console.ReadLine();
    Console.Write("Enter Target Currency: ");
    var targetCurrency = Console.ReadLine();
    Console.Write("Enter Amount: ");
    var amount = decimal.Parse(Console.ReadLine() ?? "0");
    var exchangeAmount = CurrencyConverter.Instance.Convert(baseCurrency!, targetCurrency!, amount);
    Console.WriteLine($"{amount} {baseCurrency} = {exchangeAmount} {targetCurrency}");
    Console.WriteLine("-------------------------------------------------------------");
}