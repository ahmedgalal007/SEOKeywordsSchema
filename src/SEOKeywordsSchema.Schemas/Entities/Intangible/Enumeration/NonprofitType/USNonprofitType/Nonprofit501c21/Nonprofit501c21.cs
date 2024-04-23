using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.NonprofitTypes.USNonprofitTypes;
public class Nonprofit501c21 : USNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(Nonprofit501c21);
}
