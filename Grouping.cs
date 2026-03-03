/*
5️⃣ Grouping

Problem:
Group students by Pass / Fail (Pass ≥ 40).
*/
class Student
{
    public int Marks;
    public string Name;
    public Student(int marks, string name)
    {
        Marks=marks;
        Name=name;
        
    }
}
class Grouping
{
    static void Main(string[] args)
    {
        List<Student> students=new List<Student>
        {
            new  Student(98,"nitin"),
            new Student(43,"mukesh"),
            new  Student(32,"madhvan")
            
        };
        var passOrFail=students.GroupBy(s=>s.Marks>=40?"pass":"fail");
        foreach(var group in passOrFail)
        {
                Console.WriteLine(group.Key);
                foreach(var student in group)
            {
                Console.WriteLine($"{student.Name}-{student.Marks}");
            }
        }
        
    }
}