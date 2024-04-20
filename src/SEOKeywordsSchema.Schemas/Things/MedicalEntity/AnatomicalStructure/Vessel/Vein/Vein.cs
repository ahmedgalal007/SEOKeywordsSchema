using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.AnatomicalStructures.Vessels;
public class Vein : Vessel
{
    public override string TypeName { get; protected set; } = nameof(Vein);
}
