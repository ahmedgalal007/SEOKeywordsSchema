using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Vessel;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Vessel.Artery;
public class Artery : Vessel
{
    public override string TypeName { get; protected set; } = nameof(Artery);
}
