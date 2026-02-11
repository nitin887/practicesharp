using System.Data.Common;

public interface IRepository<T>
{
    void Add(T item);
    List<T> GetAll();
    void  Remove(T item);
}
class Student
{
    public int Id
    {
        get;
        set;
    }
    public String Name
    {
        get;
        set;
    }

}
class StudentRepository:IRepository<Student>
{
    private List<Student> students= new List<Student>();
    public void Add(Student student)
    {
        students.Add(student);
        Console.WriteLine("student added with :{0}",student.Name);
        
    }
    public List<Student> GetAll()
    {
        return students;

        
    }
    public void Remove(Student student)
    {
        students.Remove(students);
        Console.WriteLine("student removed with :{0}",student.Name);
        
    }
    
}

class RepositoryPattern
{
    static void Main(string[] args)
    {
        IRepository<Student> repository =new StudentRepository();
        repository.Add(new Student{
            Id=1,Name="Nitin"
            });
        repository.Add(new Student
        {
            Id=2,Name="DIxit"
        });
        Console.WriteLine("All student:/n");
        foreach (var item in repository.GetAll())
        {
            Console.WriteLine($"{item.Id}-{item.Name}");
            
        }
        repository.Remove(repository.GetAll());
        
    }
}