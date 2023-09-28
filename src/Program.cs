using Danske_Currency_Exchange_Povilas.src.ConversionRatesProvider;
using Danske_Currency_Exchange_Povilas.src.CurrencyConverter;
using System;

public class Program
{
    static void Main(string[] args)
    {
        // Check for the correct number of command-line arguments
        if (args.Length != 2 || !args[0].Contains('/'))
        {
            Console.WriteLine("Usage: Exchange <currency pair (USD/USD format)> <amount to exchange>");
            return;
        }

        // Split the source and target currencies
        string[] currencies = args[0].Split('/');
        string sourceCurrency = currencies[0].ToUpper();
        string targetCurrency = currencies[1].ToUpper();
        double amount;

        // Check if the amount passed is usable and if currencies are correct
        if (!double.TryParse(args[1], out amount))
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        // Create an instance of the conversion rates provider
        IConversionRatesProvider ratesProvider = new DictionaryConversionRatesProvider();

        // Create an instance of the CurrencyConverter
        CurrencyConverter converter = new CurrencyConverter(ratesProvider);

        // Perform the currency conversion
        double exchangedAmount = converter.Convert(sourceCurrency, targetCurrency, amount);

        // Display the result
        Console.WriteLine($"{amount} {sourceCurrency}/{targetCurrency} is equivalent to {exchangedAmount.ToString("F4")} {targetCurrency}.");
    }
}
