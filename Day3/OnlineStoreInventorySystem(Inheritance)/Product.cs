using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreInventorySystem_Inheritance_
{
    internal class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product() { }
        
        public Product(string productId, string name, double price, int qunatity) 
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Quantity = qunatity;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product Id:{ProductId} \nName: {Name} \nPrice: {Price} \nQuantity: {Quantity}");
        }

    }

    class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics() { }
        public Electronics(string productId, string name, double price, int qunatity, string brand) : base(productId, name, price, qunatity)
        {
            Brand = brand;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Brand: {Brand}");
        }
    }
       

        
    
    
    class Clothing : Product
    {
        public string Size { get; set; }
        public Clothing() { }
        public Clothing(string productId, string name, double price, int qunatity,string size) : base(productId, name, price, qunatity)
        {
                Size = size;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Size: {Size}");
        }

    }

    class Books : Product
    {
        public string Author { get; set; }
        public Books() { }

            public Books(string productId, string name, double price, int quantity, string author) : base(productId, name, price, quantity)
            {
                Author = author;
            }
            public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Author: {Author}");
        }
    }
}

