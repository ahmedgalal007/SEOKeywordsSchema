using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.NonprofitTypes;
public class NLNonprofitType : NonprofitType
{
    public override string TypeName { get; protected set; } = nameof(NLNonprofitType);
}


// TODO Member NonprofitANBI
// TODO Member NonprofitSBBI