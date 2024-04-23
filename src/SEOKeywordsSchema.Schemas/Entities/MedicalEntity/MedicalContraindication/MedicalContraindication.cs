using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalContraindication : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalContraindication);
}
