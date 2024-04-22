using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using SEOKeywordsSchema.Schemas.SchemaProperties.Things.Property;

namespace SEOKeywordsSchema.Schemas.Things;
[EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<Thing>))]
public class Thing : BaseSchemaEntity, ISchemaEntity
{
    // protected abstract string Definition { get; }
    // public Guid Id { get; private set; }
    public virtual string TypeName { get; protected set; } = nameof(Thing);
    public AdditionalType? AdditionalType { get; private set; }
    public string? Description { get; private set; } = string.Empty;
    public Text? DisambiguatingDescription { get; private set; }
    public string? Identifier { get; private set; }
    public Image? Image { get; private set; }
    public MainEntityOfPage? MainEntityOfPage { get; private set; }
    public Text? Name { get; private set; } = new Text("");
    public string? PotentialAction { get; private set; }
    public URL? SameAs { get; private set; }
    public SubjectOf? SubjectOf { get; private set; }
    public URL? Url { get; private set; }
    public Thing? Parent { get; set; }
    public String SchemaType { get; set; }

    public Boolean IsLeafe()
    {
        throw new NotImplementedException();
    }
}
