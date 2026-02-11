interface IIprintable
{
 void Print();   
}
class Invoice:IIprintable
{
 public void Print()
    {
        Console.WriteLine("you recieved a invoice");
        
    }
    
}
class Report:IIprintable
{
    public void Print()
    {
        Console.WriteLine("you recieved a invoie");
        
    }
    
}
class PrintableInterface
{
    static void Main(string[] args)
    {
        Invoice invoice = new Invoice();
        invoice.Print();
        Report report = new Report();
        report.Print();

    }
}