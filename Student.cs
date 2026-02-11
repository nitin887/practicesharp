/*
🟢 BASIC LEVEL
1️⃣ Student Class

Concepts: Class, Object, Constructor, Properties

Problem:
Create a Student class with:

Properties: Id, Name, Marks

A constructor to initialize all properties

A method Display() to print student details

Task:
Create an object of Student and call Display().
*/
class Student
{

        public int Id{
            get;
            set;
        }
        public double Marks{
            get;
            set;
        }
        public string Name{
            get;
            set;
        }
        public Student(int id,string name,double marks){
            Id=id;
            Name=name;
            Marks=marks;
        }
        public void Display(){
            Console.WriteLine($"Id: {Id}, Name: {Name}, Marks: {Marks}");
        }
    static void  Main(string[] args)
    {
        Student student= new Student(1,"John",85.5);
        student.Display();
       

    }
        
    }

