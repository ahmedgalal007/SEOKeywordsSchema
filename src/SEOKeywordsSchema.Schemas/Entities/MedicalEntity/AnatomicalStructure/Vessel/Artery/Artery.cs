using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.AnatomicalStructures.Vessels;
public class Artery : Vessel
{
    public override string TypeName { get; protected set; } = nameof(Artery);
}
