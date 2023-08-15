using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingCart
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Item Name: {Name} Item Price: {Price} Item Quantity: {Quantity}";
        }
    }

}


