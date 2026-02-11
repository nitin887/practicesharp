using System.Reflection.Metadata;

class LibraryBookSystem
{
    private string title;
    private string author;
    private bool isAvailable;

    public string Title
    {
        get
        {
            return title;
        }   
    }
    public String Author
    {
        get
        {
            return author;
        }   
    }
    public bool IsAvailable
    {
        get
        {
            return isAvailable;
        }
    }
    public LibraryBookSystem(string title,string author,bool isAvailable)
    {
        this.title=title;
        this.author=author;
        this.isAvailable=isAvailable;
    }
    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable=false;
            Console.WriteLine("book is borrowed");

        }
        else
        {
            Console.WriteLine("book already borrowed");
        }

        
    }
    public void ReturnBook()
    {
        if (!isAvailable)
        {
            isAvailable=true;
            Console.WriteLine("book is returned");
            
        }
        else
        {
            Console.WriteLine("book is not borrowed");
            
        }
        
    }
    static void Main(string[] args)
    {
     LibraryBookSystem libraryBookSystem=new LibraryBookSystem("the white stone","anand mehta",false);
    
     libraryBookSystem.ReturnBook();


        
    }
}