using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.NonprofitTypes.USNonprofitTypes;
public class Nonprofit501c3 : USNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(Nonprofit501c3);
}
