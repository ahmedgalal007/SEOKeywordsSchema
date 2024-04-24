using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Entities;
using SEOKeywordsSchema.Schemas.Entities.CreativeWorks;
using SEOKeywordsSchema.Schemas.Persistence.Contexts;

namespace Host.Persistence.Contexts;

public class ApplicationDbContext : SEOKeywordsSchemaDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
            
    }

    // public DbSet<Report> Reports { get; set; }
    // public DbSet<SatiricalArticle> SatiricalArticles { get; set; }
    // public DbSet<Person> Persons { get; set; }
    // public DbSet<Organization> Organizations { get; set; }
    // public DbSet<Organization> Organizations { get; set; }
    // public DbSet<Place> Places { get; set; }
    // public DbSet<EventReservation> EventReservations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
