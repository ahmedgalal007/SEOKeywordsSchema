using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DDxElement;
public class DDxElement : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DDxElement);
}
