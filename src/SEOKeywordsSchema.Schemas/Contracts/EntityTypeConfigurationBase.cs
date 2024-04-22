using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SEOKeywordsSchema.Schemas.Contracts;


public class EntityTypeConfigurationBase<TEntity>: IEntityTypeConfiguration<TEntity>
    where TEntity : class
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.ToTable(typeof(TEntity).Name, "Schema");
    }
}

public class PropertyTypeConfigurationBase<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : class
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.ToTable(typeof(TEntity).Name, "Schema.Property");
    }
}

