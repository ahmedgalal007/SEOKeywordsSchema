using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Extensions;
public static class SEOKeywordsSchemaDbContextExtensions
{
    public static async Task<TEntity?> FindTrackedAsync<TEntity>(this SEOKeywordsSchemaDbContext context, TEntity entity) where TEntity : class
    {
        var entityType = context.Model.FindRuntimeEntityType(typeof(TEntity));
        var keyProperties = entityType?.FindPrimaryKey()?.Properties;

        if (keyProperties is null)
            return null;

        var keyValues = keyProperties.Select(prop => prop.GetGetter().GetClrValue(entity)).ToArray();
        return await context.FindAsync<TEntity>(keyValues);
    }
}
