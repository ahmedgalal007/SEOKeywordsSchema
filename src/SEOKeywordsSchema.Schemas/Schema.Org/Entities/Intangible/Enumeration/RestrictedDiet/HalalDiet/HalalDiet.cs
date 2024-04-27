using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RestrictedDiet;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.RestrictedDiet.HalalDiet;
public class HalalDiet : RestrictedDiet
{
    public override string TypeName { get; protected set; } = nameof(HalalDiet);
}
