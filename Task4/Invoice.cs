namespace Task4;
/*
 * Завдання 4
   
   Використовуючи Visual Studio, створіть проект за 
   шаблоном Console Application.
   
   Потрібно: Створити клас Invoice. 
   У тілі класу створити три поля 
   int account, string customer, string provider, 
   які мають бути проініціалізовані один раз 
   (при створенні екземпляра даного класу) без можливості їхньої подальшої зміни. 
   
   У тілі класу створити два закриті поля 
   string article, int quantity 
   
   Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ. 
   Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.
 */
public class Invoice
{
    private readonly int account;
    private readonly string customer;
    private readonly string provider;
    private string article;
    private int quantity;
    private double pricePerItem;

    public Invoice(int account, string customer, string provider)
    {
        this.account = account;
        this.customer = customer;
        this.provider = provider;
    }

    public void SetArticleAndQuantity(string article, int quantity)
    {
        this.article = article;
        this.quantity = quantity;
    }

    public void SetPricePerItem(double pricePerItem)
    {
        this.pricePerItem = pricePerItem;
    }

    private double CalculateTotalPrice(bool includeVat)
    {
        // Ціни на товари і податок можуть бути визначені в класі або ввести зовні
        double vatRange = 0.2; // Ставка ПДВ (20%)

        double totalPrice = pricePerItem * quantity;

        if (includeVat)
        {
            // Додаємо ПДВ до загальної вартості
            totalPrice = totalPrice * (1 + vatRange);
        }

        return totalPrice;
    }

    public double CalculateTotalPriceWithVat()
    {
        return CalculateTotalPrice(includeVat: true);
    }
    
    public double CalculateTotalPriceWithoutVat()
    {
        return CalculateTotalPrice(includeVat: false);
    }
}