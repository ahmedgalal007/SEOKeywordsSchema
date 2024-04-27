using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Quantity;
public class Quantity : Intangible
{
    public override string TypeName { get; protected set; } = nameof(Quantity);
}


// TODO Distance
// TODO Duration
// TODO Energy
// TODO Mass