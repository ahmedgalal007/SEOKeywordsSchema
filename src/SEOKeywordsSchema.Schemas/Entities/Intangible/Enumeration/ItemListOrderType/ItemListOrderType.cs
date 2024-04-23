using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations;
public class ItemListOrderType : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(ItemListOrderType);
}


// TODO Member ItemListOrderAscending
// TODO Member ItemListOrderDescending
// TODO Member ItemListUnordered