using SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.NonprofitTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.NonprofitTypes.UKNonprofitTypes;
public class UKTrust : UKNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(UKTrust);
}
