using SEOKeywordsSchema.Schemas.SchemaEntities;
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
        await Task.Delay(500);
        return result;
    }
    public Thing Save(Thing entity)
    {
        _context.Things.Add(entity);
        _context.SaveChanges();
        return entity;
    }
    public async Task<Thing> SaveAsync(Thing entity)
    {
        await _context.Things.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<Thing> UpdateAsync(Thing entity)
    {
        _context.Things.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
