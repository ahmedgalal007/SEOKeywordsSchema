using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType.USNonprofitType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType.USNonprofitType.Nonprofit501c1;
public class Nonprofit501c1 : USNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(Nonprofit501c1);
}
