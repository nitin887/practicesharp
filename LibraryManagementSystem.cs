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
using System;
using System.Collections.Generic;

class Library
{
    public int Id;
    public string BookName;
    public string AuthorName;
    public int Quantity;

    public Library(int id, string bookName, string authorName, int quantity)
    {
        Id = id;
        BookName = bookName;
        AuthorName = authorName;
        Quantity = quantity;
    }
}

class LibraryManagementSystem
{
    Dictionary<int, Library> books = new Dictionary<int, Library>();
    Queue<string> waitingList = new Queue<string>();
    Stack<string> recentlyReturned = new Stack<string>();

    void AddBooks()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Book Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Author Name:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            int quantity = int.Parse(Console.ReadLine());

            books[id] = new Library(id, name, author, quantity);
        }
    }

    void GetAllBooks()
    {
        Console.WriteLine("\nAll Books:");
        foreach (var book in books.Values)
        {
            Console.WriteLine($"{book.Id} - {book.BookName} - {book.AuthorName} - Qty: {book.Quantity}");
        }
    }

    void BorrowBook()
    {
        Console.WriteLine("Enter Book Id to borrow:");
        int id = int.Parse(Console.ReadLine());

        if (books.ContainsKey(id))
        {
            var book = books[id];

            if (book.Quantity > 0)
            {
                book.Quantity--;
                Console.WriteLine("Book borrowed successfully");
            }
            else
            {
                Console.WriteLine("Book not available. Added to waiting list.");
                waitingList.Enqueue(book.BookName);
            }
        }
        else
        {
            Console.WriteLine("Book not found");
        }
    }

    void ReturnBook()
    {
        Console.WriteLine("Enter Book Id to return:");
        int id = int.Parse(Console.ReadLine());

        if (books.ContainsKey(id))
        {
            var book = books[id];
            book.Quantity++;

            recentlyReturned.Push(book.BookName);
            Console.WriteLine("Book returned successfully");
        }
    }

    void ShowWaitingList()
    {
        Console.WriteLine("\nWaiting List:");
        foreach (var item in waitingList)
        {
            Console.WriteLine(item);
        }
    }

    void ShowRecentlyReturned()
    {
        Console.WriteLine("\nRecently Returned:");
        foreach (var item in recentlyReturned)
        {
            Console.WriteLine(item);
        }
    }

    static void Main()
    {
        var system = new LibraryManagementSystem();

        system.AddBooks();
        system.GetAllBooks();

        system.BorrowBook();
        system.ReturnBook();

        system.ShowWaitingList();
        system.ShowRecentlyReturned();
    }
}