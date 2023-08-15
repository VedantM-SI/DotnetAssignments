namespace OnlineStoreInventorySystem_Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product;
            do
            {
                Console.WriteLine("Enter 1 for electronics, 2 for Clothing, 3 for Books");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        product = new Electronics();
                        Electronics electronics = new Electronics("E001", "Laptop",800,10,"Dell");
                        electronics.DisplayDetails();
                        break;
                    case 2:
                        product = new Clothing();
                        Clothing clothing = new Clothing("C001","T-shirt",20,50,"Medium");
                        clothing.DisplayDetails();
                        break;
                    case 3:
                        product = new Books();
                        Books book = new Books("B001","Harry Potter and The Sorcerer's Stone",15,20, "J.K.Rowling");
                        book.DisplayDetails();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }while (true);
        }
    }
}