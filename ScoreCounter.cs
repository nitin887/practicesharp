using System.Security.Cryptography.X509Certificates;
using System;
namespace Counter
{
    class ScoreCounter
    {
         
        static void Main()
        {
        int[] score=[100,120,130,456];
        int totalScore=0;
    for(int i = 0; i < score.Length; i++) 
    {
        totalScore+=score[i];
        }

        double avg=(double)totalScore/score.Length;
        Console.WriteLine($"total score is: {totalscore}");
        Console.WriteLine($"avg is :{avg}");

        }   }
}
