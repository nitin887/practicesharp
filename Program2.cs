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
      public int value;
      public string itemName;
      public ItemType itemType;
      public Item(int value,string itemName,ItemType itemType)
      {
        this.value=value;
        this.itemName=itemName;
        this.itemType=itemType;
      }
        }

      class Player
  {
    public int heath =100;
    public int mana =50;
    public int damage=10;
    
  }
    class Inventory
    {


        
    }
    class Program2
    {
      public static void Main()
        {
            
        }
        
    }
}