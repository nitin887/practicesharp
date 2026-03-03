/*
8️⃣ Dictionary + LINQ

Problem:
Given a dictionary of products and prices, find:

Products costing more than 1000

Total price of all products
*/

using System.Data;

class DictionaryAndLinq
{ 
    static void Main(string[] args)
    {
     double totalPrice=0;
      Dictionary<string,int> keyValuePairs = new Dictionary<string, int>
      {
         {"phone",19000},{"toy",1294},{"cloth",134}
          
      };
      foreach(KeyValuePair<string,int>  keyValuePair in keyValuePairs)
        {
            if(keyValuePair.Value>1000){
            Console.WriteLine($"{keyValuePair.Key}-{keyValuePair.Value}");
        }}
        foreach(KeyValuePair<string,int> keyValuePair1 in keyValuePairs)
        {
            totalPrice+=keyValuePair1.Value;

        }
        Console.WriteLine("price:"+totalPrice);
        
        
         


        

    
        

        
    }
}