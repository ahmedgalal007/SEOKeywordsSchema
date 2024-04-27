using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Joint;
public class Joint : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Joint);
}
