namespace OnlineShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ShoppingCart shoppingCart = new ShoppingCart();
            do{ 
            Console.WriteLine("1.Add items to the cart");
            Console.WriteLine("2.Display items of the cart");
            Console.WriteLine("3.Calculate cost of the cart");
            Console.WriteLine("4.Exit the program");
            Console.WriteLine("Enter the choice");
      
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                            Console.WriteLine("Enter the item name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the item price");
                            double price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter the item quantity");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            shoppingCart.Additems(name, price, quantity);
                            Console.WriteLine("Item added successfully");
                            
                            break;
                    case 2:
                             shoppingCart.DisplayItems();
                             break;
                    case 3:
                        
                            Console.WriteLine($"Total Cart Cost is:{shoppingCart.CalculateCartCost()}");
                            break;
                    case 4:
                            return;
                    default:
                        
                            Console.WriteLine("Enter a valid choice");
                        
                        break;
                }
            }while(true);
            
        }
    }
}