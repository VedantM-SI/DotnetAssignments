using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Quantity { get; set; }

        public Book(string title, string author, string genre, int quantity)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Book Title: {Title} Book Author: {Author} Book Genre:{Genre} Quantity: {Quantity}";
        }

        public override bool Equals(object? obj)
        {
            if((obj!= null)){
                Book book = obj as Book;
                if(this.Title == book.Title || this.Author == book.Author )
                    return true ;
            }
            return false ;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Author) ;
        }
    }
}
