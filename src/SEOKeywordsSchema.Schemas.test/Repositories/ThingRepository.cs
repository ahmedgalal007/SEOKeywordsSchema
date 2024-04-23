using SEOKeywordsSchema.Schemas.Entities;
using SEOKeywordsSchema.Schemas.Persistence.Contexts;

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
