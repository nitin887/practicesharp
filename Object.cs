using System;
using System.Collections.Generic;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Rectangle : Shape
{
    public int length = 3;
    public int breadth = 5;
    public override double CalculateArea()
    {
        return length * breadth;
    }
}

class Circle : Shape
{
    public int radius = 6;
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Rectangle(),
            new Circle()
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.CalculateArea());
        }
    }
}