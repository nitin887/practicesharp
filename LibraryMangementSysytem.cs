//user need to specify their roles
//1.normal task
//2.accountant
//user need to choose what to do
//1.withdraw
//2.deposit
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

using System;
using System.Collections.Generic;
using System.Linq;

interface IOperations
{
    void AddBook();
    void DeleteBook();
    void SearchBookById();
    void GetAllBooks();
    void WithdrawBooks();
    void DepositBooks();
}

abstract class Library
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string AuthorName { get; set; }

    public string BookName { get; set; }
}

class Book : Library
{
}

class LibraryOperations : IOperations
{
    List<Book> data = new List<Book>();

    int bookId = 0;

    public void AddBook()
    {
        Console.WriteLine("Enter number of books:");
        int size = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            Book book = new Book();

            book.Id = bookId++;

            Console.WriteLine("Enter Book Name:");
            book.BookName = Console.ReadLine();

            Console.WriteLine("Enter Author Name:");
            book.AuthorName = Console.ReadLine();

            data.Add(book);

            Console.WriteLine("Book Added Successfully\n");
        }
    }

    public void DeleteBook()
    {
        Console.WriteLine("Enter Book Name to delete:");
        string name = Console.ReadLine();

        Book foundBook = data.FirstOrDefault(b => b.BookName == name);

        if (foundBook != null)
        {
            data.Remove(foundBook);
            Console.WriteLine("Book Deleted Successfully");
        }
        else
        {
            Console.WriteLine("Book Not Found");
        }
    }

    public void SearchBookById()
    {
        Console.WriteLine("Enter Book Id:");
        int id = Convert.ToInt32(Console.ReadLine());

        Book foundBook = data.FirstOrDefault(b => b.Id == id);

        if (foundBook != null)
        {
            Console.WriteLine($"{foundBook.Id} - {foundBook.BookName} - {foundBook.AuthorName}");
        }
        else
        {
            Console.WriteLine("Book Not Found");
        }
    }

    public void GetAllBooks()
    {
        if (data.Count == 0)
        {
            Console.WriteLine("No Books Available");
            return;
        }

        foreach (Book book in data)
        {
            Console.WriteLine($"{book.Id} - {book.BookName} - {book.AuthorName}");
        }
    }

    public void WithdrawBooks()
    {
        Console.WriteLine("Enter Book Name to Withdraw:");
        string name = Console.ReadLine();

        Book foundBook = data.FirstOrDefault(b => b.BookName == name);

        if (foundBook != null)
        {
            data.Remove(foundBook);
            Console.WriteLine("Book Withdrawn Successfully");
        }
        else
        {
            Console.WriteLine("Book Not Available");
        }
    }

    public void DepositBooks()
    {
        Book book = new Book();

        book.Id = bookId++;

        Console.WriteLine("Enter Book Name:");
        book.BookName = Console.ReadLine();

        Console.WriteLine("Enter Author Name:");
        book.AuthorName = Console.ReadLine();

        data.Add(book);

        Console.WriteLine("Book Deposited Successfully");
    }
}

class Role
{
    public void SpecifyingRole()
    {
        LibraryOperations task = new LibraryOperations();

        while (true)
        {
            Console.WriteLine("\nChoose Role:");
            Console.WriteLine("1. User");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. Withdraw Book");
                    Console.WriteLine("2. Deposit Book");

                    int userChoice = Convert.ToInt32(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            task.WithdrawBooks();
                            break;

                        case 2:
                            task.DepositBooks();
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Delete Book");
                    Console.WriteLine("3. Search Book");
                    Console.WriteLine("4. Display All Books");

                    int adminChoice = Convert.ToInt32(Console.ReadLine());

                    switch (adminChoice)
                    {
                        case 1:
                            task.AddBook();
                            break;

                        case 2:
                            task.DeleteBook();
                            break;

                        case 3:
                            task.SearchBookById();
                            break;

                        case 4:
                            task.GetAllBooks();
                            break;
                    }
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}

class LibraryManagementSystem
{
    static void Main()
    {
        Role role = new Role();
        role.SpecifyingRole();
    }
}