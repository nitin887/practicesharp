/*
🟢 BASIC LEVEL
1️⃣3️⃣ Abstract Animal

Concept: Abstract Class

Problem:
Abstract class Animal

Abstract method: MakeSound()

Derived classes:

Dog

Cat*/
abstract class Animal
{
public  abstract void Makesound();
    
}
class Dog:Animal
{
    public override void Makesound()
    {
        Console.WriteLine("animal is a dog");
    }
    
}
class Cat:Animal
{
    public override void Makesound()
    {
        Console.WriteLine("animal is a cat");
    }
    
}
class Creature
{
    static void Main(string[] args)
    {
        Animal animal= new Dog();
        animal.Makesound();
        Animal animal1= new Cat();
        animal1.Makesound();
        
    }
}
