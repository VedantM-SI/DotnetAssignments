namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            do
            {
                Console.WriteLine("1.Add the book");
                Console.WriteLine("2.Display the list of books");
                Console.WriteLine("3.Search for books by Title or Author");
                Console.WriteLine("5.Exit the program");

                Console.WriteLine("Enter the choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the title of the book");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the author of the book");
                        string authorName = Console.ReadLine();
                        Console.WriteLine("Enter the genre of the book");
                        string genre = Console.ReadLine();
                        Console.WriteLine("Enter the quantity of books");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        library.addBooks(title, authorName, genre, quantity);
                        Console.WriteLine("Book added successfully");
                        break;
                    case 2:
                        library.DisplayBooks();
                        break;
                    case 3:
                        library.SearchBooks();
                        break;
                    
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                };
            } while (true);
        }
    }
}

         