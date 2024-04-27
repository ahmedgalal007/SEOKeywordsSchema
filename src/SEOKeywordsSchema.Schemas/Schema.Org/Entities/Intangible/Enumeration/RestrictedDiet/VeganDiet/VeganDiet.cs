using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RestrictedDiet;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RestrictedDiet.VeganDiet;
public class VeganDiet : RestrictedDiet
{
    public override string TypeName { get; protected set; } = nameof(VeganDiet);
}
