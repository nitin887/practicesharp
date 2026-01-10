using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Transactions;

class Palindrome
{//write a c# program to check whether a string is palindrome or not
    static void Main(string[] args)
    {
        string  name ="nitxn";
        int size=name.Length;
        int start=0;
        int end=size-1;
        bool isPalindrome=true;
       
        while (start < end)
        {
            if (name[start] != name[end])

            {
                isPalindrome=false;
                break;
         
                }
            else if(name[start]==name[end]){
                isPalindrome=true;
                start++;
                end--;
                
                
                }
        }
        if(isPalindrome==true){
            Console.WriteLine("no is palindrome");
        }
        else
        {
            Console.WriteLine("no is not palindrome");
        }
       
  




    }
}