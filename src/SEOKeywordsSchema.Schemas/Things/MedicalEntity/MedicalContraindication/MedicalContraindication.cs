using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalContraindication : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalContraindication);
}
