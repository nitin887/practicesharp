/*
4️⃣ Sorting with LINQ

Problem:
Sort students by marks descending, then by name ascending.
*/
class Student
{
    public int Marks;
    public string Name;
    
    public Student(int marks,string name)
    {
        Marks=marks;
        Name=name;
        
    }
    
}
class SortingWithLinq
{
    static void Main(string[] args)
    {
        List<Student> students=new List<Student>
        {
            new Student(98,"nitin"),
            new  Student(34,"hitesh"),
            new Student(21,"rakesh"),
            new Student(46,"vidyut")
        };
        var sortedStudent=students.OrderByDescending(s=>s.Marks).ThenBy(s=>s.Name);
        foreach(var result in sortedStudent)
        {
            Console.WriteLine("soring:"+result.Marks+result.Name);
        }


        
    }
}