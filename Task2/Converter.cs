using System.Reflection.Metadata;

namespace ClassesAndObjectsTasks;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
   Потрібно: Створити клас Converter.
   У тілі класу створити користувальницький конструктор, який приймає три речові аргументи,
    і ініціалізує поля, що відповідають курсу 3-х основних валют, по відношенню до гривні
    – public Converter (double usd, double eur, double zl).
     Написати програму, яка
    виконуватиме конвертацію з гривні в одну із зазначених валют, також програма повинна
    проводити конвертацію із зазначених валют у гривню.
 */
public class Converter
{ 
    private double usd;
    private double eur;
    private double zl;

    public Converter(double usd, double eur, double zl)
    {
        this.usd = usd;
        this.eur = eur;
        this.zl = zl;
    }

    public double ConvertToUsd(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEuro(double uah)
    {
        return uah / eur;
    }

    public double ConvertToZl(double uah)
    {
        return uah / zl;
    }
    
    public double ConvertFromUsd(double usdAmount)
    {
        return usdAmount * usd;
    }

    public double ConvertFromEur(double eurAmount)
    {
        return eurAmount * eur;
    }

    public double ConvertFromZl(double zlAmount)
    {
        return zlAmount * zl;
    }
}