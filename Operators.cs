/*
Implement multiplication using only addition.
*/
using System;

class Operator
{
    static void Main(string[] args)
    {
     int a=5;
     int b=10;
     int result=0;
     for(int i = 1; i <=b ;i++)
     {
       result=a+result;  
    }
    Console.WriteLine("Multiplication of 5 using addition is: " + result);
    }
}