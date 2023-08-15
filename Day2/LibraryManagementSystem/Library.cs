using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        List<Book> books = new List<Book>();

        public void addBooks(string title, string author, string genre, int quantity)
        {
            Book newBook = new Book(title, author, genre, quantity);
            books.Add(newBook);
        }

        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void SearchBooks()
        {
            Console.WriteLine("Enter the title or author name: ");
            string input = Console.ReadLine();
            foreach (Book book in books)
            {
                if (input.Equals(book.Title) || input.Equals(book.Author))
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
