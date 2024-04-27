using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MapCategoryType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MapCategoryType.TransitMap;
public class TransitMap : MapCategoryType
{
    public override string TypeName { get; protected set; } = nameof(TransitMap);
}
