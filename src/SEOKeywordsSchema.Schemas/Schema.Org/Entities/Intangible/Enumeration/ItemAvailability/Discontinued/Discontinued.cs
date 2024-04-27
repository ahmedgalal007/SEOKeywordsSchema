using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemAvailability;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemAvailability.Discontinued;
public class Discontinued : ItemAvailability
{
    public override string TypeName { get; protected set; } = nameof(Discontinued);
}
