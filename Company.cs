/*
1️⃣2️⃣ Custom Data Structure with Indexers

Create a class Company.

Requirements:

Store employees in a dictionary

Create indexer that accesses employee by ID

Allow adding, updating, retrieving employees.

Example:

company[101] = "Alice";
Console.WriteLine(company[101]);

*/
class Company
{
    Dictionary<int, string> employee = new Dictionary<int, string>();
    public void AddEmplyoee(int id, string employeeName)
    {
        employee.Add(id, employeeName);
    }
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < employee.Count)
            {
                return employee[index];
            }
            return "invalid index";
        }
        set
        {
            employee[index] = value;
        }
    }

    static void Main()
    {
        Company company = new Company();
        company.AddEmplyoee(0, "nitin");
        company.AddEmplyoee(1, "mukesh");
        Console.WriteLine(company[0]);
        company[1] = "rajesh";



    }
}