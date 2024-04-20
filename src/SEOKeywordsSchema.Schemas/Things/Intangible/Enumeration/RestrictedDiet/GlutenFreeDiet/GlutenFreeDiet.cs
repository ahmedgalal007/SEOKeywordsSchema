using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.RestrictedDiets;
public class GlutenFreeDiet : RestrictedDiet
{
    public override string TypeName { get; protected set; } = nameof(GlutenFreeDiet);
}
