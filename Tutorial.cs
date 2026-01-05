using System.Runtime.CompilerServices;

namespace MyPractice
{
    class Tutorial
    {
        static void Main()
        {
         int[] health=[100,90,75,60,85];
         int max=health[0];
         int min =health[0];
         for(int i = 1; i < health.Length; i++) {
                if (health[i] < min)
                {
                   min =health[i];
                }
               if(health[i]>max)
                {
                    max=health[i];
                }
             
             

                
               }
               Console.WriteLine("{max} max value and {min} min value"+max,min);
               
            
         }   
        

         }


        }
    
