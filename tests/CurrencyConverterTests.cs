using Danske_Currency_Exchange_Povilas.src.ConversionRatesProvider;
using Danske_Currency_Exchange_Povilas.src.CurrencyConverter;
using Moq;
using Xunit;

namespace Danske_Currency_Exchange_Povilas.Tests
{
    public class CurrencyConverterTests
    {
        [Fact]
        public void Convert_ConvertsCurrencyCorrectly()
        {
            // Arrange
            var sourceCurrency = "USD";
            var targetCurrency = "EUR";
            var amount = 100.0;

            // Create a mock of the IConversionRatesProvider interface
            var mockRatesProvider = new Mock<IConversionRatesProvider>();

            // Set up the mock behavior for specific currencies
            mockRatesProvider.Setup(provider => provider.GetRate("USD")).Returns(1.0);
            mockRatesProvider.Setup(provider => provider.GetRate("EUR")).Returns(0.9);

            // Create an instance of the CurrencyConverter and inject the mock
            var converter = new CurrencyConverter(mockRatesProvider.Object);

            // Act
            var result = converter.Convert(sourceCurrency, targetCurrency, amount);

            // Assert
            // Verify that the conversion is as expected
            Assert.Equal(90.0, result);
        }
    }
}
