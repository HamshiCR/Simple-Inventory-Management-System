using Microsoft.EntityFrameworkCore;

namespace ERPWebApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Example DbSet for the first module (e.g., Products)
        public DbSet<Product> Products { get; set; }
    }

    // Example Product model for Inventory module
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
} 