//Program.cs
namespace ProductCatalogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog myCatalog = new Catalog();
            myCatalog.LoadFromCsv("products.csv");
            myCatalog.GroupByCategory();

            myCatalog.GetByCategory("Food");

            myCatalog.GetCheapestInCategory("Food");

            myCatalog.GetTotalStockValue();

            myCatalog.GetAveragePrice();

            myCatalog.GetProductsSortedByPrice();

            myCatalog.GetProductCount("Food");

            Console.ReadKey();
        }
    }
}
