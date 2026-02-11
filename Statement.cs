abstract class Shape
{
    public abstract double CalculateArea();
    public abstract void Display();
    
}
class Rectangle:Shape
{
   public int Length=3;
   public int Breadth=4;

    public override double CalculateArea()
    {
       return Length*Breadth;
    }
    public override void Display()
    {
        Shape shape2 = new Rectangle();
        Console.WriteLine($"area of rectangle:{shape2.CalculateArea()}");
        
    }
    
}
class Circle:Shape
{
    public int radius=4;

    public override double CalculateArea()
    {
        return Math.PI*radius*radius;
    }
    public override void Display()
    {
        Shape shape3= new Circle();
        Console.WriteLine($"area of cirle:{shape3.CalculateArea()}");
    }
}
class Statement
{
    static void Main(string[] args)
    {
        Shape shape= new Rectangle();
        shape.Display();
        Shape shape1=new Circle();
        shape1.Display();
        
    }
    
}
