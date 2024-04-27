using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class MedicalContraindication : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalContraindication);
}
