using AMS24.Store.Shoes.Models.Entities;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// <author>Daniel<author>
/// </summary>
class DataContext : DbContext
{
   public DataContext (DbContextOptions<DataContext> options) : base(options)
   {
    
   }
   public DbSet<Color> Color  { get; set; }
   public DbSet<Size> Size  { get; set; }
   public DbSet<Product> Product { get; set; }
}