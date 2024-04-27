using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.ItemListOrderTypes;
public class ItemListOrderDescending : ItemListOrderType
{
    public override string TypeName { get; protected set; } = nameof(ItemListOrderDescending);
}
