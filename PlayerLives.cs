using System;
namespace Player
{
    class PlayerLives
    {
        static void Main()
        {
            int[] livesLost=[0,1,0,1,1];
            int lives=3;
            for(int i = 0; i < livesLost.Length; i++) {
                if (livesLost[i] == 0)
                {
                    lives--;
                }
                else if (livesLost[i] == 1)
                {
                    lives++;
                }
                
            }
            if(lives<0)
            Console.WriteLine($"lives:{lives} !alive");
            else
            {
                Console.WriteLine("game over");
            }
        }
    }
}