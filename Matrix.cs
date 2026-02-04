class Matrix
{
   static void Main(string[] args)
    {
        //
        int [,] matrix={{1,2},{2,3}};
        int [,] matrix1={{2,3},{3,4}};
        int[,] product=new int[2,2];
        for(int i = 0; i <2 ; i++) {
            for(int j = 0; j <2 ; j++) {
             product[i,j]=0;
             for(int k = 0; k < 2; k++)
                {
                    product[i,j]+=matrix[i,k]*matrix1[k,j];
                   
                }
                 Console.Write(product[i,j]+" ");
                
            }
            Console.WriteLine();
          
        }
       

    }
    
}