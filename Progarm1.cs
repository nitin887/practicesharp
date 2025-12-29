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
using System;

namespace Miniproject2
{
    enum EnemyState
    {
        Idle,
        Attack,
        Chase
    }

    class Enemy
    {
        private float distance;
        private float maxDistance;
        private EnemyState state;

        public Enemy()
        {
            distance = 5.0f;
            maxDistance = distance;
            state = EnemyState.Idle;
            Console.WriteLine("Enemy at distance: " + maxDistance);
        }

        public void UpdateState(float newDistance)
        {
            distance = newDistance;
            maxDistance = newDistance;

            if (distance < 5.0f)
            {
                state = EnemyState.Attack;
            }
            else if (distance < 15.0f)
            {
                state = EnemyState.Chase;
            }
            else
            {
                state = EnemyState.Idle;
            }

            Console.WriteLine($"Enemy is at distance: {maxDistance}\nState: {state}");
        }
    }

    public class Program1
    {
        static void Main()
        {
            Enemy enemy = new();
            enemy.UpdateState(2.9f);
        }
    }
}