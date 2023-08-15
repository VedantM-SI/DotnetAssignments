using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingCart
{
    internal class ShoppingCart
    {
        List<Item> items = new List<Item>();

        public void Additems(string name, double price, int quantity)
        {
            Item newitem = new Item(name, price, quantity);
            items.Add(newitem);
        }


        public void DisplayItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }

        public double CalculateCartCost()
        {
            double totalCost = 0;
            foreach (Item item in items)
            {
                totalCost += item.Quantity * item.Price;
            }
            return totalCost;
        }
        public double TotalCartCost
        {
            get { return CalculateCartCost(); }

        }
    }
}
