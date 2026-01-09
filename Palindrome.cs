using System.Runtime.InteropServices;
using System.Transactions;

class Palindrome
{
    static void Main(string[] args)
    {
        string  name ="nitxn";
        int size=name.Length;
        int start=0;
        int end=size-1;
        bool s= false;
        while (start < end)
        {
            if (name[start] != name[end])
            {
              Console.WriteLine("not a plaindrome");
            }
            else
            {
                s=true;
            }
            start++;
             end--;

        }
        Console.WriteLine("number is palindrome:{0}",s);
  




    }
}