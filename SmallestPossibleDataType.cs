class SmallestPossibleDataTpe
{
    static void Main(string[] args)
    {
        string input=Console.ReadLine();
       Console.WriteLine(DeterminingSmallestDatatype(input));
      
        
    }
    static string DeterminingSmallestDatatype(string input)
    {
        byte abyte;
        if(byte.TryParse(input,out abyte))
        {
            return "byte";
        }
        short ashort;
        if(short.TryParse(input,out ashort))
        {
            return "short";
        }
        int aint;
        if(int.TryParse(input,out aint))
        {
            return "integer";
        } 
        char achar;
        if(char.TryParse(input,out achar))
        {
            return "char";
        }
        float afloat;
        if(float.TryParse(input,out afloat))
        {
            return "float";
        }
        double adouble;
        if(double.TryParse(input,out adouble))
        {
            return "double";
        }   
        return "string or unsupported type";
        
    }
}