using GaB_TechnicalService_Backend.DbConnector.Models;
using Microsoft.EntityFrameworkCore;

namespace GaB_TechnicalService_Backend.DbConnector;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(GaB_TechnicalService_Backend.ConfigurationManager.ConnectionStringProtectedDb);
    }
}