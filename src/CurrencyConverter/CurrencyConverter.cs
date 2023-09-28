using Danske_Currency_Exchange_Povilas.src.ConversionRatesProvider;

namespace Danske_Currency_Exchange_Povilas.src.CurrencyConverter
{
    public class CurrencyConverter
    {
        private readonly IConversionRatesProvider ratesProvider;

        public CurrencyConverter(IConversionRatesProvider ratesProvider)
        {
            this.ratesProvider = ratesProvider;
        }

        public double Convert(string sourceCurrency, string targetCurrency, double amount)
        {
            double sourceToDKK = ratesProvider.GetRate(sourceCurrency);
            double targetToDKK = ratesProvider.GetRate(targetCurrency);

            return amount * sourceToDKK / targetToDKK;
        }
    }
}
