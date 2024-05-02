using Task6;

class Program
{
    static void Main(string[] args)
    {
        //string login, string name, string surname, int age, int dateOfFillingOut
        Console.WriteLine("Add user login: ");
        string login = Console.ReadLine();
        
        Console.WriteLine("Add user name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Add user surname: ");
        string surname = Console.ReadLine();

        Console.WriteLine("Add user age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Add user date of Filling out questionare: ");
        string dateOfFillingOut = Console.ReadLine();
        
        
        User user = new User(login, name, surname, age, dateOfFillingOut);
        user.showUserInfo();
    }
    
}