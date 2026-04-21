/*
🧩 2. Student Marks Validator
🎯 Concept: Application-Level Exception

Problem:
Create a program where the user enters marks (0–100).

⚠️ Requirements:
If marks < 0 or > 100 → throw custom exception InvalidMarksException
Handle using try-catch
Display proper error message
*/
class InvalidMarksException : Exception
{
    public InvalidMarksException(string message) : base(message)
    {

    }

}
class StudentMarksValidator
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter Marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0 || marks > 100)
            {
                throw new InvalidMarksException("marks is less than 0 or equal to 100");

            }
        }
        catch (InvalidMarksException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Operation Completed");
        }


    }
}