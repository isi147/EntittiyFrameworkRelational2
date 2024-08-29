using ConsoleApp27.Context;
using ConsoleApp27.Entities;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewShopDbContext newShopDbContext = new NewShopDbContext();
            //newShopDbContext.Cashiers.Add(new Cashier() { Name = "Nazim", Surname = "Nazimli" });

            //newShopDbContext.Categories.Add(new Category() { Name = "Ickiler" });

            //newShopDbContext.Products.Add(new Product() { Name = "Hell", CategoryId = 2, });
            newShopDbContext.Orders.Add(new Order() { Adress = "Ev", CashierId = 1, ProductId = 4 });

            newShopDbContext.SaveChanges();
        }
    }
}
