class BinaryToDecimal{
    static void Main(string[] args)
    {
        /*
        1010=0*1+1*2+0*2*2+1*2*2*2;
        
        */
        string binaryNumber="1010";
        // int decimalNumber;
        // decimalNumber=Convert.ToInt32(binaryNumber,2);
        // Console.WriteLine("decimal number:"+decimalNumber);
        int power=0;
        int decimalNumber=0;
        for(int i = binaryNumber.Length-1; i >=0 ; i--) {
            if (binaryNumber[i] == '1')
            {
                decimalNumber+=(int)Math.Pow(2,power);
            }
            power++;
            
        }
        Console.WriteLine("decimal number:"+decimalNumber);
    }
    
}

