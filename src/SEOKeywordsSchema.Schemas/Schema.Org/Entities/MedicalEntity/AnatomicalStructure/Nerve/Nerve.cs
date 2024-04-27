using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Nerve;
public class Nerve : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Nerve);
}
