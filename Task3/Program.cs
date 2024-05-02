using Task3;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Yana", "Makogon");
        employee.CalculateSalaryAndTaxes("developer", 10);
    }
}