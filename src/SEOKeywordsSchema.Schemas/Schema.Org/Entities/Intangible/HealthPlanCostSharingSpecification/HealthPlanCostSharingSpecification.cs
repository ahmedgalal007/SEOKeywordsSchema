using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.HealthPlanCostSharingSpecification;
public class HealthPlanCostSharingSpecification : Intangible
{
    public override string TypeName { get; protected set; } = nameof(HealthPlanCostSharingSpecification);
}
