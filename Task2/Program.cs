using ClassesAndObjectsTasks;

class Program
{
    static void Main(string[] args)
    {
        // Введення курсів валют
        Console.WriteLine("Введіть курси валют (USD, EUR, ZL) через пробіл:");
        string[] rates = Console.ReadLine().Split(' ');
        double usdRate = double.Parse(rates[0]);
        double eurRate = double.Parse(rates[1]);
        double zlRate = double.Parse(rates[2]);

        // Створення об'єкту Converter з введеними курсами валют
        Converter converter = new Converter(usdRate, eurRate, zlRate);

        Console.WriteLine("Введіть суму в UAH для конвертації: ");
        double uah = double.Parse(Console.ReadLine());

        double usd = converter.ConvertToUsd(uah);
        double eur = converter.ConvertToEuro(uah);
        double zl = converter.ConvertToZl(uah);

        Console.WriteLine($"{uah} UAH дорівнює {usd} USD");
        Console.WriteLine($"{uah} UAH дорівнює {eur} EUR");
        Console.WriteLine($"{uah} UAH дорівнює {zl} ZL");

        Console.WriteLine("Введіть суму в іншій валюті для конвертації назад в UAH: ");
        double amount = double.Parse(Console.ReadLine());
        Console.WriteLine("Введіть код валюти (USD, EUR, ZL): ");
        string currency = Console.ReadLine();

        double convertedAmount = 0;
        switch (currency.ToUpper())
        {
            case "USD":
                convertedAmount = converter.ConvertFromUsd(amount);
                break;
            case "EUR":
                convertedAmount = converter.ConvertFromEur(amount);
                break;
            case "ZL":
                convertedAmount = converter.ConvertFromZl(amount);
                break;
            default:
                Console.WriteLine("Непідтримувана валюта");
                break;
        }

        Console.WriteLine($"{amount} {currency} дорівнює {convertedAmount} UAH");
    
    }
}