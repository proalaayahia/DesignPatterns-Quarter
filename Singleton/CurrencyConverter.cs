namespace SingletonPattern;

public class CurrencyConverter
{
    private IEnumerable<ExchangeRate> _exchangeRates = [];

    private CurrencyConverter()
    {
        LoadExchangeRate();
    }
    #region lazy initialization
    //private static readonly Lazy<CurrencyConverter> _lazyInstance = new(() => new());//lazy init
    //public static CurrencyConverter Instance
    //{
    //    get
    //    {
    //        return _lazyInstance.Value;
    //    }
    //}
    #endregion
    //Eager init
    private static CurrencyConverter _instance;
    private static object _lock = new();
    public static CurrencyConverter Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance is null)
                {
                    _instance = new();
                }
            }
            return _instance;
        }
    }

    private void LoadExchangeRate()
    {
        Thread.Sleep(3000); //simulation
        _exchangeRates =
        [
            new ExchangeRate("USD","SAR",4.75m),
            new ExchangeRate("USD","EGP",45.5m),
            new ExchangeRate("SAR","EGP",14.75m)
        ];
    }
    public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
    {
        var exchangeRate = _exchangeRates.FirstOrDefault(rate =>
        rate.BaseCurrency == baseCurrency.ToUpper() &&
        rate.TargetCurrency == targetCurrency.ToUpper()
        );
        if (exchangeRate is null)
        {
            return 0.0m;
        }
        return amount * exchangeRate.Rate;
    }
}
