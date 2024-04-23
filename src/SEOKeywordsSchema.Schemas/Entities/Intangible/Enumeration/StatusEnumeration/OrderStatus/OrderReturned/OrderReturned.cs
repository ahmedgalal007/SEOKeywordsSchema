using SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.StatusEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.StatusEnumerations;
public class OrderReturned : OrderStatus
{
    public override string TypeName { get; protected set; } = nameof(OrderReturned);
}
