using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemListOrderType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ItemListOrderType.ItemListUnordered;
public class ItemListUnordered : ItemListOrderType
{
    public override string TypeName { get; protected set; } = nameof(ItemListUnordered);
}
