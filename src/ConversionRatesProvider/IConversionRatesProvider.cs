namespace Danske_Currency_Exchange_Povilas.src.ConversionRatesProvider
{
    public interface IConversionRatesProvider
    {
        double GetRate(string currency);
    }
}
