namespace Task3;

public class Employee
{
    private string name;
    private string surname;

    public Employee(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
    
    double baseSalary = 0;

    public void CalculateSalaryAndTaxes(string position, int experience)
    {
       

        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 30000 + (experience * 900);
                break;
            case "developer":
                baseSalary = 45000 + (experience * 1200);
                break;
            case "Automation QA":
                baseSalary = 40000 + (experience * 1000);
                break;
            default:
                Console.WriteLine("Unsupported position");
                return;
        }
        double tax = baseSalary * 0.05;
        Console.WriteLine($"Surame: {surname}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"BaseSalary: {baseSalary}");
        Console.WriteLine($"Tax: {tax}");
        
    }
}