using Microsoft.EntityFrameworkCore;
namespace Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     modelBuilder.Entity<User>(entity => entity.HasIndex(e => e.EmailAddress).IsUnique(true));
      
    }

    public DbSet<User> Users {get; set;}
    public DbSet<AutoInsurance> AutoInsurances {get; set;}
    public DbSet<BusinessInsurance> BusinessInsurances {get; set;}
    public DbSet<LifeInsurance> LifeInsurances {get; set;}
    public DbSet<MedicalInsurance> MedicalInsurances {get; set;} 
}





