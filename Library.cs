/*
🔟 Overloading Indexers – Library System

Create a class Library.

Requirements:

Store books in a list

First indexer: access by index
 
Second indexer: access by book name

Return book information.

Example:

library[0]
library["C# Fundamentals"]
*/

namespace Library1
{
    public class Library
    {
        private List<string> books = new List<string>();
        public void AddMethod(string book)
        {
            books.Add(book);

        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                {
                    return books[index];
                }
                else
                {
                    return "invalid index";
                }
            }
        }
        public string this[string bookName]
        {
            get
            {
                foreach (var obj in books)
                {
                    if (obj.Equals(bookName, StringComparison.OrdinalIgnoreCase))
                    {
                        return $"book found:{obj}";

                    }

                }
                return "book not found";

            }
        }
        static void Main()
        {
            Library library = new Library();
            library.AddMethod("eng");
            library.AddMethod("hindi");
            library.AddMethod("math");

            Console.WriteLine(library[0]);
            Console.WriteLine(library["ramesh"]);


        }
    }
}