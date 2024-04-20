using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SEOKeywordsSchema.Schemas.Things;
using SEOKeywordsSchema.Schemas.Things.CreativeWorks.Articles;

namespace Host.Persistence.Configurations;

public class ThingConfig : IEntityTypeConfiguration<Thing>
{
    public void Configure(EntityTypeBuilder<Thing> builder)
    {
        builder.ToTable(nameof(Thing), SchemaNames.Schema)
            .HasDiscriminator(e => e.TypeName)
            .HasValue<CreativeWork>(nameof(CreativeWork))
            .HasValue<NewsArticle>(nameof(NewsArticle))
            .HasValue<Report>(nameof(Report))
            .HasValue<SatiricalArticle>(nameof(SatiricalArticle));
            // .HasValue<Person>(nameof(Person))
            // .HasValue<Organization>(nameof(Organization));

       builder
            .OwnsOne(thing => thing.SubjectOf, ownedNavigationBuilder =>
               {
                   ownedNavigationBuilder.ToTable("Subjects");

                   ownedNavigationBuilder.OwnsOne(subject => subject.Value1, ownedOwnedNavigationBuilder =>
                    {
                        ownedOwnedNavigationBuilder.ToTable(nameof(Person), SchemaNames.Schema);
                    });
                   ownedNavigationBuilder.OwnsOne(subject => subject.Value2, ownedOwnedNavigationBuilder =>
                   {
                       ownedOwnedNavigationBuilder.ToTable(nameof(Organization), SchemaNames.Schema);
                   });
               });
    }
}
