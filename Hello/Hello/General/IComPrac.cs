using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Product : IComparable<Product>
    {
        public string Name { get; }
        public int Price { get; }
        public string Category { get; }
        public int Quantity { get; }

        public Product(string name, int price, string category, int quantity)
        {
            Name = name;
            Price = price;
            Category = category;
            Quantity = quantity;
        }

        public int CompareTo(Product other)
        {
            // Implement custom comparison logic to sort
            // products by price in ascending order.
            if (this.Price > other.Price) return 1;
            else if (this.Price < other.Price) return -1;
            return 0;
            //return Price.CompareTo(other.Price);
        }
    }

    class CompareProducts : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.Quantity > y.Quantity) return 1;
            else if (x.Quantity < y.Quantity) return -1;
            return 0;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 1200, "Electronics", 12),
                new Product("Desk Chair", 200, "Furniture", 4),
                new Product("Phone", 700, "Electronics", 7),
                new Product("Bookshelf", 150, "Furniture", 9)
            };

            CompareProducts compareProducts = new CompareProducts();

            // Sort the list of products based on the custom sorting logic (price).
            products.Sort();
            //products.Sort(compareProducts);

            Console.WriteLine("Products sorted by price (ascending):");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Category: {product.Category}, Quantity: {product.Quantity}");
            }
        }
    }

}
