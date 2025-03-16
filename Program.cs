using System;

namespace OnlineShoppingSystem
{
    // Base Class: Product
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(string name, double price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: ${Price}, Stock: {StockQuantity}");
        }
    }
}

