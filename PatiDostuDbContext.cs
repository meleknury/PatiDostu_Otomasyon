using System.Data.Entity;

public class PatiDostuDbContext : DbContext
{
    public PatiDostuDbContext() : base("name=PatiDostuDbContext")
    {
    }

    public DbSet<Animal> Animals { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Volunteer> Volunteers { get; set; }
    public DbSet<CareRecord> CareRecords { get; set; }
}