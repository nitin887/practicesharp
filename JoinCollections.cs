/*
🔴 ADVANCED
7️⃣ Join Collections

Problem:
Join two collections:

Students (Id, Name)

Marks (StudentId, Score)
*/
class Collection
{
    
}
class Students
{
    public int Id;
    public string Name;
    public Students(int id,string name)
    {
        Id=id;
        Name=name;

    }
    
}
class Marks
{
    public int StudentId;
    public int Score;
    
    public Marks(int studentId,int score)
    {
        StudentId =studentId;
        Score=score;

        
    }
}
class JoinCollections
{
    static void Main(string[] args)
    {
        List<Students> students= new List<Students>
        {
            new Students(1,"nitin"),
            new Students(2,"mukesh"),
            new Students(3,"damhruv")
            
        };
        List<Marks> marks =new List<Marks>
        {
            new Marks(1,98),
            new Marks(2,87),
            new Marks(3,68)
            
        };
        var collection=from m in students join s in marks on m.Id equals s.StudentId  select new{m.Id,m.Name,s.Score};
        foreach(var result in collection)
        {
            Console.WriteLine($"{result}");
        }

                        
        
    }
}