using GaB_Core.DbConnector.Models;
using Microsoft.EntityFrameworkCore;
namespace GaB_Core.DbConnector;
public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(GAB_Core.ConfigurationManager.ConnectionStringProtectedDb);
    }
}