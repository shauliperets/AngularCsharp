using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data {

public class DataContext : DbContext
{
    
    public DataContext()
    {
        
    }
    

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer(@"Data Source=database.db");
        optionsBuilder.UseSqlServer("Server=localhost;Database=ShopingCartDB;User Id=sa;PWD='Ng9dozv0';Encrypt=False");
        //optionsBuilder.UseSqlServer("ShoppingCartDB");

    }
    
    
    public DbSet<User> Users { get; set; } //= null!;
}
}