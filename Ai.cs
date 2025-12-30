/*
Simple Enemy AI Logic

Level: Beginner → Intermediate
Time: 45–60 min

🎯 Goal

Enemy decides what to do based on player distance.

🧠 Game Logic

Distance < 5 → Attack

Distance < 15 → Chase

Distance ≥ 15 → Idle

🧾 Concepts Used

If / else

Methods

Enums

🧪 Your Tasks

Create EnemyState enum

Create Enemy class

Create method UpdateState(float distance)
*/
using System.Xml.Serialization;

namespace Miniproject2
{
    class Enemy

    {
        private readonly float distance;
     
        private enum EnemyState
        {
            Idle,
            Attack,
            Chase,
        
        }
        public Enemy()
        {
            distance=5.0f;
          
            Console.WriteLine("Enemy at distance:"+distance);

        }
        public void UpdateState(float distance)
        {
            if (distance >=15.0f)

            {
                Console.WriteLine("ENEMY IS AT DISTANCE:"+distance+"/n state:"+EnemyState.Idle);
                
            }
            else  if (distance < 5.0f)
                {
                    Console.WriteLine("Enemy is in mode:"+EnemyState.Attack);
                } 
            
           else {
               
                Console.WriteLine("Enemy is in at distance:"+distance +"/n sate:"+EnemyState.Chase);
               

                
            }
            
            
        }


    }
  class Ai
    {
        public static void Main()

        {
            Enemy enemy=new();
            enemy.UpdateState(15.0f);
            
        }
    }
}