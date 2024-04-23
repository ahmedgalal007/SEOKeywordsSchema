using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.GovernmentBenefitsTypes;
public class OneTimePayments : GovernmentBenefitsType
{
    public override string TypeName { get; protected set; } = nameof(OneTimePayments);
}
