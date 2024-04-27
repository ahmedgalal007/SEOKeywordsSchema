using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Audience;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Audience.MedicalAudience;
public class MedicalAudience : Audience
{
    public override string TypeName { get; protected set; } = nameof(MedicalAudience);
}

