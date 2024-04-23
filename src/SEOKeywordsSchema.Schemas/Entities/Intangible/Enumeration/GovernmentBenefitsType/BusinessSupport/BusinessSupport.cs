using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.GovernmentBenefitsTypes;
public class BusinessSupport : GovernmentBenefitsType
{
    public override string TypeName { get; protected set; } = nameof(BusinessSupport);
}
