using SEOKeywordsSchema.Schemas.Persistence.Contexts;
using SEOKeywordsSchema.Schemas.SchemaProperties;
using SEOKeywordsSchema.Schemas.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.test.Repositories;
public class ThingRepository
{
    private readonly SEOKeywordsSchemaDbContext _context;
    public ThingRepository(SEOKeywordsSchemaDbContext context)
    {
        _context = context;
    }

    public async Task<Thing?> GetById(Guid id)
    {
        var result = await _context.Things.FindAsync(id);
        return result;
    }
    public Thing Save(Thing entity)
    {
        _context.Things.Add(entity);
        _context.SaveChanges();
        return entity;
    }
}
