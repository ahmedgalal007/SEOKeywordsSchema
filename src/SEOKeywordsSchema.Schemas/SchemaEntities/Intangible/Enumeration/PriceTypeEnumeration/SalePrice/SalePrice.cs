using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.PriceTypeEnumerations;
public class SalePrice : PriceTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(SalePrice);
}
