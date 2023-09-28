using Danske_Currency_Exchange_Povilas.src.ConversionRatesProvider;

namespace Danske_Currency_Exchange_Povilas.Tests.Mocks
{
    public class MockConversionRatesProvider : IConversionRatesProvider
    {
        public double GetRate(string currency)
        {

            // Example: USD to EUR rate is 0.9
            if (currency.ToUpper() == "USD")
            {
                return 0.9;
            }

            // Example: EUR to USD rate is 1.1
            if (currency.ToUpper() == "EUR")
            {
                return 1.1;
            }

            // Return a default rate if the currency is not found
            return 1.0; // Default rate (no conversion)
        }
    }
}
