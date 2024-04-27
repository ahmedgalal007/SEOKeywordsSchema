using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType;
public class NonprofitType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(NonprofitType);
}


// TODO NLNonprofitType
// TODO UKNonprofitType
// TODO USNonprofitType