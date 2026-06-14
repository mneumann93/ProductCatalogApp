//Product.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogApp
{
    internal class Product
    {
        public int Id { get; }
        public string Name { get; }
        public string Category { get; }
        public double Price { get; }
        public int Stock { get; set; }

        public Product(int id, string name, string category, double price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Category: {Category}, Price: {Price}, Stock: {Stock}");
        }
    }
}
