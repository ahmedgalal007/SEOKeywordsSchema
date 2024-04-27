using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Quantity;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Quantity.Duration;
public class Duration : Quantity
{
    public override string TypeName { get; protected set; } = nameof(Duration);
}