/*
🔹 INTERMEDIATE LEVEL
5️⃣ List of ValueTuples – Employee Records

Create a list storing employees.

Requirements:

Use (int Id, string Name, double Salary)

Add at least 5 employees

Print employees with salary > 50000.
*/
class Employee
{
    public int Id
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }
    public double Salary
    {
        get;
        set;
    }

    public Employee()
    {
        Console.WriteLine("enter the id , name,salary:");
        int id = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        double salary = Convert.ToDouble(Console.ReadLine());
        Id = id;
        Name = name;
        Salary = salary;

    }
}
class EmployeeRecords
{

    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        for (int i = 1; i <= 5; i++)
        {
            Employee employee = new Employee();
            employees.Add(employee);
        }
        var result = employees.Where(s => s.Salary > 50000);
        foreach (var data in result)
        {
            Console.WriteLine($"{data.Name}");
        }






    }
}