using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Ligament;
public class Ligament : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Ligament);
}
