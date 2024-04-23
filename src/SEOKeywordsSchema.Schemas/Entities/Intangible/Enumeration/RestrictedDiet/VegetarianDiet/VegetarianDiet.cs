using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.RestrictedDiets;
public class VegetarianDiet : RestrictedDiet
{
    public override string TypeName { get; protected set; } = nameof(VegetarianDiet);
}
