/*
🔹 INDEXERS
7️⃣ Basic Indexer – Student Collection

Create a class StudentCollection.

Requirements:

Store student names in an array

Use indexer to get/set names

Access students like:

students[0] = "John";
Console.WriteLine(students[0]);
*/
class StudentCollection
{
    private string[] names1 = new string[5];
    public string this[int index]
    {
        get
        {
            return names1[index];
        }
        set
        {
            names1[index] = value;
        }

    }

    static void Main(string[] args)
    {
        StudentCollection studentCollection = new StudentCollection();
        studentCollection[0] = "nitin";
        studentCollection[1] = "rahul";
        studentCollection[2] = "ramesh";
        studentCollection[3] = "rajesh";
        Console.WriteLine(studentCollection[3]);



    }
}