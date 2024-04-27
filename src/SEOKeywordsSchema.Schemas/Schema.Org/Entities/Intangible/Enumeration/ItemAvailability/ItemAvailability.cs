using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemAvailability;
public class ItemAvailability : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(ItemAvailability);
}


// TODO Member BackOrder
// TODO Member Discontinued
// TODO Member InStock
// TODO Member InStoreOnly
// TODO Member LimitedAvailability
// TODO Member OnlineOnly
// TODO Member OutOfStock
// TODO Member PreOrder
// TODO Member PreSale
// TODO Member SoldOut