using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalStudies;
public class MedicalTrial : MedicalStudy 
{
    public override string TypeName { get; protected set; } = nameof(MedicalTrial);
}
