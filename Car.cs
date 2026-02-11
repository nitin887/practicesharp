class Vehicle
{   
    public string BrandName
    {
        get;
        set;
    }
    public int NumberOfDoors
    {
        get;
        set;
    }
    public void Start()
    {
        Console.WriteLine("vehicle has started running");
    }
    public Vehicle(string brandName, int numberOfDoors)
    {
        BrandName = brandName;
        NumberOfDoors = numberOfDoors;
        Console.WriteLine($"brandName:{BrandName},numberOfDoors:{NumberOfDoors}");
    }
}

class Car(string brandName, int numberOfDoors) : Vehicle(brandName, numberOfDoors)
{
    static void Main(string[] args)
    {
        Car car = new Car("maruti", 4);
        car.Start();
    }
}