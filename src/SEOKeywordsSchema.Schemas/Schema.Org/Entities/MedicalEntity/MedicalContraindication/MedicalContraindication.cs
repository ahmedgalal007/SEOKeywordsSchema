using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalContraindication;
public class MedicalContraindication : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalContraindication);
}
