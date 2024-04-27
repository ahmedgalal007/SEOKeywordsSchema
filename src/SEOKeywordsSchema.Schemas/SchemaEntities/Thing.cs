using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;
using SEOKeywordsSchema.Schemas.Types;

namespace SEOKeywordsSchema.Schemas.SchemaEntities;
// [EntityTypeConfiguration(typeof(EntityTypeConfigurationBase<Thing>))]
public class Thing : BaseSchemaEntity, ISchemaEntity
{
    // protected abstract string Definition { get; }
    // public Guid Id { get; private set; }
    public virtual string? TypeName { get; protected set; } = nameof(Thing);

    #region SchemaProperties
    public AdditionalType? AdditionalType { get; private set; }
    public AlternateName? AlternateName { get; private set; }
    public Description? Description { get; private set; }
    public DisambiguatingDescription? DisambiguatingDescription { get; private set; }
    public Identifier? Identifier { get; private set; }
    public Image? Image { get; private set; }
    public MainEntityOfPage? MainEntityOfPage { get; private set; }
    public Name? Name { get; private set; }
    public PotentialAction? PotentialAction { get; private set; }
    public SameAs? SameAs { get; private set; }
    public SubjectOf? SubjectOf { get; private set; }
    public URL? Url { get; private set; }
    #endregion

    public Thing? Parent { get; set; }


    #region Actions
    public static Thing Create(Identifier identifier, Description description, Name name, string url, Image img, PotentialAction? potentialAction = null)
    {
        // var _id = Guid.NewGuid();
        Thing result = new Thing
        {
            // Id = _id,
            TypeName = nameof(Thing),
            Identifier = identifier,
            Description = description,
            Name = name,
            Url = url,
            Image = img,
            PotentialAction = potentialAction,
        };

        return result;
    }

    public Thing Update(Description? description,Name? name, URL? url, Image? image)
    {
        if (description is not null && Description != description )  Description?.Update(description);
        if(name is not null && Name != name) Name = name;
        if(url is not null && Url != url )  Url.Update(url);
        if(image is not null && Image != image )  Image.Update(image);

        return this;
    }

    public Thing Delete(Guid id)
    {
        return this;
    }
    #endregion
}


