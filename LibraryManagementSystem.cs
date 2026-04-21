/*
🧩 14. Real-World Problem (Best Practice)
💻 Coding Problem

Library Management System

Use:
Dictionary → Book ID mapping
List → Book collection
Queue → Waiting list
Stack → Recently returned books

*/
using System.Security.AccessControl;
using Microsoft.VisualBasic;

class Library
{
    public bool IsBorrowed;

    public int Quantity;
    public int Id;
    public string BookName;

    public string AuthorName;

    public Library(int id, string bookName, string authorName, int quantity, bool isBorrowed)
    {

        Id = id;
        BookName = bookName;
        AuthorName = authorName;
        Quantity = quantity;
        IsBorrowed = isBorrowed;

    }
    public Library(string bookName, string authorName, int quantity, bool isBorrowed)
    {
        BookName = bookName;
        AuthorName = authorName;
        Quantity = quantity;
        IsBorrowed = isBorrowed;
    }
    public Library()
    {

    }
}
class LibraryMangementSysytem
{
    Dictionary<int, Library> keyValuePairs = new Dictionary<int, Library>();
    Library library1 = new Library(id, bookName, authorName, quantity, isBorrowed);


    static int x = 1;
    static int id;
    static string bookName;
    static string authorName;
    static int quantity;
    static bool isBorrowed = false;
    void AddBooks()
    {

        for (int i = 0; i < 3; i++)
        {

            Console.WriteLine("Enter the Id,bookName,AuthorName,quantity:");
            id = Convert.ToInt32(Console.ReadLine());
            bookName = Console.ReadLine();
            authorName = Console.ReadLine();
            quantity = 1;

            keyValuePairs.Add(x, new Library(id, bookName, authorName, quantity, isBorrowed));
            x++;


        }
        foreach (var data1 in keyValuePairs)
        {
            Console.WriteLine($"{data1.Key}-{data1.Value.Id}-{data1.Value.AuthorName}-{data1.Value.BookName}");
        }


    }
    void GetAllBooks()
    {
        List<Library> libraries = new List<Library>();
        for (int i = 0; i < 3; i++)
        {
            libraries.Add(new(bookName, authorName, quantity, isBorrowed));




        }
        foreach (var data in libraries)
        {
            Console.WriteLine($"{data.BookName}");
        }

    }
    void WaitingList()
    {
        Queue<string> library = new Queue<string>();
        Console.WriteLine("Enter the bookName to withdraw:");
        string bookName = Console.ReadLine();

        if (library1.BookName == bookName)
        {

            if (quantity == 0)
            {
                isBorrowed = true;
                Console.WriteLine("!unable to borrow:" + bookName);

            }
            else if (quantity < 0)
            {
                throw new Exception("quantity cannot be negative");
            }
            else if (quantity > 0)
            {
                quantity--;
                isBorrowed = true;
                library.Enqueue(bookName);
                Console.WriteLine("Book has been borrowed");
            }


        }

    }
    void ReturningBooks()
    {
        Stack<string> libraries1 = new Stack<string>();
        Console.WriteLine("Enter the book you want ");
        string bookName = Console.ReadLine();
        if (library1.BookName == bookName)
        {
            if (quantity == 0)
            {
                isBorrowed = true;
                quantity++;
                isBorrowed = false;
                libraries1.Push(bookName);
                Console.WriteLine("book has been returned");

            }
            else if (quantity < 0)
            {
                throw new Exception("book qunatity cannot be negative");
            }


        }
        if (quantity > 0)
        {
            isBorrowed = false;
            Console.WriteLine("book has not been borrowed");
        }


    }


    static void Main()
    {
        LibraryMangementSysytem libraryMangementSysytem = new LibraryMangementSysytem();
        libraryMangementSysytem.AddBooks();
        libraryMangementSysytem.GetAllBooks();
        libraryMangementSysytem.WaitingList();
        libraryMangementSysytem.ReturningBooks();




    }


}
