using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Entities;
using SEOKeywordsSchema.Schemas.Entities.CreativeWorks;

namespace Host.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
            
    }

    // public DbSet<Person> Persons { get; set; }
    // public DbSet<NewsArticle> NewsArticles { get; set; }
    public DbSet<Thing> Things { get; set; }
    public DbSet<Article> Articles { get; set; }

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
