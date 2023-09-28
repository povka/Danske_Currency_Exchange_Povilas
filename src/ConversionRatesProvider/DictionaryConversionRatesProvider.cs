using Danske_Currency_Exchange_Povilas.src.ConversionRatesProvider;

public class DictionaryConversionRatesProvider : IConversionRatesProvider
{
    //100 of said currency equals specified amount of Danish Krone
    private static readonly Dictionary<string, double> conversionRates = new Dictionary<string, double>
    {
        {"DKK", 100},      // Base rate of 100 Krone
        {"EUR", 743.94},
        {"USD", 663.11},
        {"GBP", 852.85},
        {"SEK", 76.10},
        {"NOK", 78.40},
        {"CHF", 683.58},
        {"JPY", 5.9740}
        // Add more conversion rates as needed...
    };

    public double GetRate(string currency)
    {
        if (conversionRates.TryGetValue(currency, out var rate))
        {
            return rate;
        }

        throw new InvalidOperationException($"Currency {currency} not found.");
    }
}
