using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemListOrderType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemListOrderType.ItemListOrderDescending;
public class ItemListOrderDescending : ItemListOrderType
{
    public override string TypeName { get; protected set; } = nameof(ItemListOrderDescending);
}
