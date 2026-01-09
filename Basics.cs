/*
Reverse an Array

Print the array in reverse order.*/
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Net;

class Basics
{
    static void Main(string[] args)
    {
        string message="nitix";
        int start=0;
        int size=message.Length;
        int end=size-1;
        char[] a=message.ToArray();
        while (start < end)
        {
            (a[end], a[start]) = (a[start], a[end]);
            start++;
            end--;
        }
        string message1=new(a);
        Console.WriteLine(message1);
   


      
        
     
          



    }
          
        
}
        


        
     
      
    
   

     

       
        
   
        

    



