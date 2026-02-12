using System.Runtime.InteropServices;

abstract class Product
{
    public int Id
    {
        get;
    }
    public string Name
    {
        get;
    }
    public double Price
    {
        get;
    }
    protected Product(int id,string name,double price)
    {
        Id=id;
        Name=name;
        Price=price;
        
    }
    public abstract double GetPrice();
}
interface IDiscountable
{
    double ApplyDiscount();
}
class Electronics : Product
{
    private double WarrantyFee=500;
    public Electronics(int id,string name,double price):base(id,name,price)
    {
        
    }
    public override double GetPrice()
    {
        return Price+WarrantyFee;
    }
}
class Clothing:Product,IDiscountable
{
    private const double discountRate=0.10;
    public Clothing(int id,string name,double price):base(id,name,price)
    {
        
    }
    public double ApplyDiscount()
    {
        return Price*discountRate;
    }
    public override double GetPrice()
    {
        return Price-ApplyDiscount();
    }
    
}
class Cart
{
    private readonly List<Product> products =new List<Product>();
    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("product added :{0}",product.Name);
       
    }
    public double CalculateTotal()
    {
        double total=0;
        foreach(Product product in products)
        {
            total+=product.GetPrice();
        }
        return total;
        
    }
}
class OnlineShoppingSystem
{
    static void Main(string[] args)
    {
        Cart cart = new Cart();
        Product laptop= new Electronics(1,"Laptop",60000);
        Product tshirt= new Clothing(2,"t-shirt",6000);
        cart.AddProduct(laptop);
        cart.AddProduct(tshirt);
        Console.WriteLine("Total cart amount"+cart.CalculateTotal());
        
    }
}