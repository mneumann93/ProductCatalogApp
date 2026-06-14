//Catalog.cs
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProductCatalogApp
{
    internal class Catalog
    {
        public List<Product> Products { get; }
        public Dictionary<string, List<Product>> ByCategory { get; }

        public Catalog()
        {
            Products = [];
            ByCategory = [];
        }

        public void LoadFromCsv(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines.Skip(1))
            {
                string[] values = line.Split(",");
                int id = int.Parse(values[0]);
                double price = double.Parse(values[3], CultureInfo.InvariantCulture);
                int stock = int.Parse(values[4]);

                Product product = new Product(id, values[1], values[2], price, stock);
                Products.Add(product);
            }
        }

        public void GroupByCategory()
        {
            foreach (Product product in Products)
            {
                if (!ByCategory.ContainsKey(product.Category))
                {
                    ByCategory[product.Category] = new List<Product>();
                }
                ByCategory[product.Category].Add(product);
            }
        }

        public void GetByCategory(string category)
        {
            if (!ByCategory.ContainsKey(category))
            {
                Console.WriteLine("The category was not found!");
            }
            else
            {
                Console.WriteLine($"The following products are in category {category}:");
                foreach (Product product in ByCategory[category])
                {
                    product.GetInfo();
                }
            }
        }

        public void GetCheapestInCategory(string category)
        {
            if (!ByCategory.ContainsKey(category))
            {
                Console.WriteLine("The category was not found!");
            }
            else
            {
                Product cheapest = ByCategory[category].OrderBy(p => p.Price).First();
                cheapest.GetInfo();
            }
        }

        public void GetTotalStockValue()
        {
            double result = Products.Sum(p => p.Price * p.Stock);
            Console.WriteLine($"The total stock value is {result}");
        }

        public void GetAveragePrice()
        {
            double average = Products.Average(p => p.Price);
            Console.WriteLine($"The average price is {average}");
        }

        public void GetProductsSortedByPrice()
        {
            var sorted = Products.OrderBy(p => p.Price);
            foreach (Product product in sorted)
            {
                product.GetInfo();
            }
        }

        public void GetProductCount(string category)
        {
            if (!ByCategory.ContainsKey(category))
            {
                Console.WriteLine("The category was not found!");
            }
            else
            {
                int count = Products.Count(p => p.Category == category);
                Console.WriteLine($"The total count of products in the {category} is {count}");
            }
        }

    }
}
