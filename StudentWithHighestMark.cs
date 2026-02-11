class StudentWithHighestMark{

    static void Main(string[] args)
    { int max= 0;
     var marks=new Dictionary<string, int>
     {
       {"nitin",76},
       {"rahul",83},
       {"rakesh",99}  
     };
     string topStudent="";
     foreach(var data in marks)
        {
            if (data.Value > max)
            {
                max=data.Value;
                topStudent=data.Key;

                
            }

        }
        Console.WriteLine(topStudent);

    }
}