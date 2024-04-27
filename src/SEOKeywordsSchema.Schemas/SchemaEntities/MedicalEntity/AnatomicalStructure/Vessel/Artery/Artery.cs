using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.AnatomicalStructures.Vessels;
public class Artery : Vessel
{
    public override string TypeName { get; protected set; } = nameof(Artery);
}
