namespace Propperties;

class Car
{
    private string model = string.Empty;

    public static void Main()
    {
        //  names of employees earning at least 150,000 dollars who are 28 or younger, sorted alphabetically
        Employee employee = new Employee { firstName = "Titus", lastName = "Muthomi", Salary = 500000, Age = 35 };
        Employee employee1 = new Employee { firstName = "Eric", lastName = "Mwenda", Salary = 50000, Age = 25 };
        Employee employee2 = new Employee { firstName = "Martin", lastName = "Mwiti", Salary = 150000, Age = 28 };
        Employee employee3 = new Employee { firstName = "Alvin", lastName = "Mwiti", Salary = 1500000, Age = 28 };

        
        // standard loops
        List<Employee> employees = new List<Employee>();
        employees.Add(employee);
        employees.Add(employee1);
        employees.Add(employee2);
        employees.Add(employee3);

        var filtered = new List<Employee>();
        
        foreach(var emp in employees)
        {
            if (emp.Salary >= 150000)
            {
                filtered.Add(emp);
            }
        }
        
        // sorting
        
        filtered.Sort((x, y) => x.firstName.CompareTo(y.firstName));
        foreach (var emp in filtered)
        {
            Console.WriteLine(emp.firstName);
        }
        
        Console.WriteLine();
        
        Console.WriteLine("Filtering and sorting usng linq");
        // Filtering and sorting usng linq
        
        var filteredEmployees = from em in employees
            where em.Salary >= 150000 && em.Age <= 30 orderby em.firstName select em;
        
        foreach(var em in filteredEmployees)
        {
            Console.WriteLine(em.firstName);
        }
        
        // Use method syntax
        Console.WriteLine();
        Console.WriteLine("Using method syntax");

        var ems = employees.Where(x => x.Salary <= 150000).OrderBy(x => x.firstName);

        foreach (var name in ems)
        {
            Console.WriteLine(name.firstName);
        }
        
        // Even Numbers
        Console.WriteLine(" Even Numbers");

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 98, 76, 43, 23, 54, 65 };

        var even = from num in numbers where num % 2 == 0 orderby num descending select num;
        // method syntax
        var evens = numbers.Where(num => num % 2 == 0).OrderBy(num => num);
        
        Console.WriteLine("Ascending");
        foreach (var num in evens)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine();
        
        // Descending
        Console.WriteLine("Descending");
        foreach (var num in even)
        {
            Console.Write(num + " ");
        }
        
        // Projection
        
        Console.WriteLine();
        Console.WriteLine("Projection");

        var slaries = from emplo in employees
            select new
            {
                emplo.Salary,
                emplo.Age

            };

        foreach (var sal in slaries)
        {
            Console.WriteLine(sal);
        }
        
        Console.WriteLine("Using Let Keyword");

        var newSalaried = from slariedEmployee in employees
            let newSalary = slariedEmployee.Salary * 1.2m
            select new Employee()
            {
                firstName = slariedEmployee.firstName,
                lastName = slariedEmployee.lastName,
                Salary = newSalary
            };

        foreach (var sal in newSalaried)
        {
            Console.WriteLine($"{sal.firstName} new salary is {sal.Salary}");
        }
        
        // Multiple SOurces
        Console.WriteLine("Queries from Multiple sources");
        var firstNames = new List<string>() { "John", "Patrick", "Lynda", "Albert", "Amanda" };
        var lastNames = new List<string>() { "Maxwell", "Smith", "Muthomi", "Muthoni", "Mwenda" };

        var possibleCombos = from first in firstNames
            from last in lastNames
            select $"{first} {last}";

        foreach (var combo in possibleCombos)
        {
            Console.WriteLine(combo);
        }
        
        // var combos = firstNames

    }


    public string Model
    {
        get { return model;}
        set { model = value; }
    }

    private decimal price;

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }
    
    public decimal year { get; set; }
}

public class Employee
{
    public required string firstName { get; init; }
    public required string lastName { get; init; }

    public decimal Salary { get; set; }
    public int Age { get; set; }
    

}