/*
PROJECT 4: Inventory System

Level: Intermediate
Time: 1–1.5 hours

🎯 Goal

Store and use items.

🧠 Game Logic

Player can pick items

Player can use items

Items affect player stats

🧾 Concepts Used

Lists

Classes

Loops

🧪 Your Tasks

Create Item class

Create Inventory class

Methods:

AddItem()

UseItem()

RemoveItem()*/

using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
namespace MiniProject2
{
    
    public enum ItemType
    {
        Healthpotion,
        Manapotion,
        Damageboost
    }

    class Item
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }

        public Item(string name, ItemType type, int value)
        {
            Name = name;
            Type = type;
            Value = value;
        }
    }

    class Player
    {
        public int health = 100;
        public int mana = 50;
        public int damage = 10;

        public void PlayerStatus()
        {
            Console.WriteLine($"Health:{health}, Mana:{mana}, Damage:{damage}");
        }
    }

    class Inventory
    {
        List<Item> items = new List<Item>();
        private Player player;

        public Inventory(Player player)
        {
            this.player = player;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine("Item added to inventory: " + item.Name);
        }

        public void UseItem(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                Console.WriteLine("Invalid index of item");
                return;
            }

            Item item = items[index];

            switch (item.Type)
            {
                case ItemType.Healthpotion:
                    player.health += item.Value;
                    Console.WriteLine("Used Health Potion");
                    break;

                case ItemType.Manapotion:
                    player.mana += item.Value;
                    Console.WriteLine("Used Mana Potion");
                    break;

                case ItemType.Damageboost:
                    player.damage += item.Value;
                    Console.WriteLine("Used Damage Boost");
                    break;
            }

            items.RemoveAt(index);
        }
    }

    class Program2
    {
        static void Main()
        {
            Player player = new();
            Inventory inventory = new(player);

            inventory.AddItem(new Item("Health Potion", ItemType.Healthpotion, 20));
            inventory.AddItem(new Item("Mana Potion", ItemType.Manapotion, 10));
            inventory.AddItem(new Item("Damage Boost", ItemType.Damageboost, 5));

            player.PlayerStatus();
            inventory.UseItem(0); // use health potion
            player.PlayerStatus();
        }
    }
}