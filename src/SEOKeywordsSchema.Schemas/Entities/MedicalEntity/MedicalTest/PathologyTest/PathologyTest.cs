using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class PathologyTest : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(PathologyTest);
}
