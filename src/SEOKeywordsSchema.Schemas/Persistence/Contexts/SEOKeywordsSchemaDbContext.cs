using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using SEOKeywordsSchema.Schemas.SchemaEntities;
using SEOKeywordsSchema.Schemas.SchemaProperties;

namespace SEOKeywordsSchema.Schemas.Persistence.Contexts;
public class SEOKeywordsSchemaDbContext : DbContext
{
    public SEOKeywordsSchemaDbContext(DbContextOptions options) : base(options)
    {

    }
    public SEOKeywordsSchemaDbContext(DbContextOptions<SEOKeywordsSchemaDbContext> options) : base(options)
    {
        
    }

    public DbSet<Thing> Things { get; set; }
    public DbSet<Article> Articles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SEOKeywordsSchemaDbContext).Assembly);

    }
}
