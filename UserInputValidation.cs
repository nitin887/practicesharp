/*
🟡 INTERMEDIATE LEVEL
4️⃣ User Input Validation

Concept: Multiple catch blocks

Problem:
Take user input for age.

Handle:

Non-numeric input

Negative values
*/
class UserInputValidation
{
    static void Main(string[] args)
    {
        
      
        try
        {

         Console.WriteLine("enter the age:");
        uint age=Convert.ToUInt32(Console.ReadLine());       
          Console.WriteLine(age);
          
          }
          catch(OverflowException es)
        {
            Console.WriteLine(es.Message);
        }
         
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}