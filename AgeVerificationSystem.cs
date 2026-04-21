/*
🧩 7. Age Verification System
🎯 Concept: Throw Keyword

Problem:
Check if a user is eligible to vote.

⚠️ Requirements:
If age < 18 → throw InvalidAgeException
Use throw manually
Handle in Main()
*/
using System.Data;

class InvalidAgeException : Exception
{

    public InvalidAgeException(string message) : base(message)
    {


    }
}
class AgeVerificationSystem
{
    static void Main()
    {
        try
        {
            Console.WriteLine("enter the age to verify:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                throw new InvalidAgeException("AGE IS NOT PERMISSIBLE TO VOTE");
            }
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}