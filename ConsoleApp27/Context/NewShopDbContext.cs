using ConsoleApp27.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp27.Context;

internal class NewShopDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Cashier> Cashiers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0116-01;Initial Catalog = NewShopDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }
}
