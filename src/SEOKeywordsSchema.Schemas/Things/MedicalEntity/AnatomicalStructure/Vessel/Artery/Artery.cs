using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.AnatomicalStructures.Vessels;
public class Artery : Vessel
{
    public override string TypeName { get; protected set; } = nameof(Artery);
}
