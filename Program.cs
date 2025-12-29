using System;

/*
Level: Beginner
Time: 30–45 min

🎯 Goal

Simulate player health, damage, healing, and death.

🧠 Game Logic

Player starts with 100 health

Can take damage

Can heal

If health ≤ 0 → Player is dead

🧾 Concepts Used

Variables

Methods

If/else

Debug / Console output

🧪 Your Tasks

Create Player class

Add health variable

Create methods:

TakeDamage(int amount)

Heal(int amount)

CheckAlive()
*/
namespace Miniproject
{
    public class Player
    {
        private int health;
        private bool isAlive;
        private const int MaxHealth = 100;

        public Player()
        {
            health = MaxHealth;
            isAlive = true;
            Console.WriteLine("player created with health:" + health);
        }

        public void TakeDamage(int amount)
        {
            if (!isAlive)
            {
                Console.WriteLine("Player is Dead");
                return;
            }

            health -= amount;
            Console.WriteLine("player health deducted");
            Console.WriteLine("current health:" + health);
            CheckAlive();
        }

        public void Heal(int amount)
        {
            if (!isAlive)
            {
                Console.WriteLine("player is dead");
                return;
            }

            health += amount;
            if (health > MaxHealth) health = MaxHealth;
            Console.WriteLine("player health incremented");
            Console.WriteLine("current health:" + health);
            CheckAlive();
        }

        public void CheckAlive()
        {
            if (health <= 0)
            {
                isAlive = false;
                Console.WriteLine("player is dead");
            }
            else
            {
                Console.WriteLine("Player is alive");
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            Player player = new();
            player.Heal(30);
            player.TakeDamage(42);
           
        }
    }
}