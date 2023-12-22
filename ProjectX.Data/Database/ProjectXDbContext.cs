using Microsoft.EntityFrameworkCore;

namespace ProjectX.Data.Database;

public class ProjectXDbContext: DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Operator> Operators { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=ProjectX; User Id=sa; Password=sa1234SA; MultipleActiveResultSets=true; Trust Server Certificate=true;");
    }
}
