using Task4;

class Program
{
    static void Main(string[] args)
    {
        // Створення екземпляра класу Invoice з фіксованими полями
        Invoice invoice = new Invoice(12345, "Yana_Makogon",
            "Microsoft");
        
        // Встановлення артикулу і кількості та прайсуЦшту товару
        Console.WriteLine("Add articule name: ");
        string article = Console.ReadLine();
        
        Console.WriteLine("Add quantity: ");
        int quantity = int.Parse(Console.ReadLine()); 
        
        Console.WriteLine("Please add price per item:");
        double pricePerItem = double.Parse(Console.ReadLine());
        invoice.SetArticleAndQuantity(article, quantity);
        invoice.SetPricePerItem(pricePerItem);
        
        // Розрахунок та виведення суми оплати з ПДВ та без ПДВ
        double totalPriceWithVat = invoice.CalculateTotalPriceWithVat();
        double totalPriceWithoutVat = invoice.CalculateTotalPriceWithoutVat();

        Console.WriteLine($"Total price with VAT: {totalPriceWithVat}");
        Console.WriteLine($"Total price without VAT: {totalPriceWithoutVat}");

    }
}