using System;

namespace EnemyCountPerLevel
{
    class EnemyCounter
    {

        static void Main()
        {
        int[] enemies = new int[] { 5, 8, 12, 3, 7 };

            int maxEnemy = enemies[0];
            int maxLevel = 1;

            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] > maxEnemy)
                {
                    maxEnemy = enemies[i];
                }
                maxLevel = i + 1;
            }

            Console.WriteLine($"maxlevel no :{maxLevel} and maximum enemies:{maxEnemy}");
            
        }
    }
}