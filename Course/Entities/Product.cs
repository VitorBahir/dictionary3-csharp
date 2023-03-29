using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product(int id, int quantity, double price)
        {
            Id = id;
            Quantity = quantity;
            Price = price;
        }

        public double Total(int quantity, double price)
        {
            return Price * quantity;
        }
    }
}