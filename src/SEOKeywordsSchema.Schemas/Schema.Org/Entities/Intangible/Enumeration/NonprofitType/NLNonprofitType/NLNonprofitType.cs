using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType.NLNonprofitType;
public class NLNonprofitType : NonprofitType
{
    public override string TypeName { get; protected set; } = nameof(NLNonprofitType);
}


// TODO Member NonprofitANBI
// TODO Member NonprofitSBBI