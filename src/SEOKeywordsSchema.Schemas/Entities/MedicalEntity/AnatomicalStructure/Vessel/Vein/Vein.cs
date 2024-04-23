using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.AnatomicalStructures.Vessels;
public class Vein : Vessel
{
    public override string TypeName { get; protected set; } = nameof(Vein);
}
