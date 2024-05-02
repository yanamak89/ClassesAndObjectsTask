namespace Task6;

/*
 * Завдання 6
   
   Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
   Потрібно: 
   Створити клас User, 
   що містить інформацію про користувача 
   (логін, ім'я, прізвище, вік, дату заповнення анкети). 
   Поле дата заповнення анкети має бути проініціалізоване лише один раз 
   (при створенні екземпляра цього класу) без можливості його подальшої зміни.
   Реалізуйте виведення на екран інформації про користувача.
 */
public class User
{
    private string login;
    private string name;
    private string surname;
    private int age;
    private readonly string dateOfFillingOut;

    public User(string login, string name, string surname, int age, string dateOfFillingOut)
    {
        this.login = login;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.dateOfFillingOut = dateOfFillingOut;
    }

    public void showUserInfo()
    {
        Console.WriteLine($"\nInformation about user -> \nLogin: {login}, \nName and Surname: {name} {surname}," +
                          $" \nAge: {age}, \nDate of filling out the questionnaire: {dateOfFillingOut}");
    }
}