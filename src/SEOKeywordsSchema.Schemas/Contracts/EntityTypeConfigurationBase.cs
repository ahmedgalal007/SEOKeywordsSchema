using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SEOKeywordsSchema.Schemas.Contracts;


public class EntityTypeConfigurationBase<TEntity>: IEntityTypeConfiguration<TEntity>
    where TEntity : class
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.ToTable(typeof(TEntity).Name, "Schema.Entities");
    }
}

public class TypeConfigurationBase<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : class
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.ToTable(typeof(TEntity).Name, "Schema.Types");
    }
}

public class PropertyTypeConfigurationBase<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : class
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.ToTable(typeof(TEntity).Name, typeof(TEntity).Namespace.Replace("SEOKeywordsSchema.Schemas.", ""));
    }
}

