/*
PROJECT 5: Turn-Based Combat System

Level: Intermediate → Advanced
Time: 2 hours

🎯 Goal

Simulate player vs enemy combat.

🧠 Game Logic

Player attacks

Enemy attacks

Turns alternate

Fight ends when someone dies

🧾 Concepts Used

Classes

Methods

Enums

While loop

🧪 Your Tasks

Create Character base class

Inherit Player and Enemy

Create Attack() method

Control turns with enum*/


using System;
using System.Threading;

namespace Miniproject3
{
    enum Tasks { Attack, Defend }

    class Character
    {
        public string Name { get; }
        public int MaxHealth { get; protected set; }
        public int CurrentHealth { get; protected set; }
        public bool Attacking { get; set; }
        public bool IsAlive => CurrentHealth > 0;

        public Character(string name, int maxHealth = 100)
        {
            Name = name;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Attacking = false;
        }

        public void ReceiveDamage(int dmg)
        {
            CurrentHealth = Math.Max(0, CurrentHealth - dmg);
            Console.WriteLine($"{Name} takes {dmg} damage (HP: {CurrentHealth}/{MaxHealth})");
            if (CurrentHealth == 0) Console.WriteLine($"{Name} has died.");
        }
    }

    class Player : Character
    {
        public Player(string name = "Player") : base(name) { }

        public void Attack(Enemy enemy)
        {
            int damage = 10;
            Console.WriteLine($"{Name} attacks {enemy.Name}!");
            enemy.ReceiveDamage(damage);
        }
    }

    class Enemy : Character
    {
        public Enemy(string name = "Enemy") : base(name) { }

        public void Attack(Player player)
        {
            int damage = 8;
            Console.WriteLine($"{Name} attacks {player.Name}!");
            player.ReceiveDamage(damage);
        }
    }

    class Program3
    {
        static void Main()
        {
            var player = new Player();
            var enemy = new Enemy();

            bool playersTurn = true;
            while (player.IsAlive && enemy.IsAlive)
            {
                if (playersTurn) player.Attack(enemy);
                else enemy.Attack(player);

                playersTurn = !playersTurn;
                Thread.Sleep(300);
            }

            Console.WriteLine("Fight ended.");
        }
    }
}
