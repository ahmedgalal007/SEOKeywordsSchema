using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.ItemListOrderTypes;
public class ItemListUnordered : ItemListOrderType
{
    public override string TypeName { get; protected set; } = nameof(ItemListUnordered);
}
