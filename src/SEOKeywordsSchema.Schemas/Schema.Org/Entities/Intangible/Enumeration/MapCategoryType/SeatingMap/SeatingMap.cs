using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MapCategoryType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MapCategoryType.SeatingMap;
public class SeatingMap : MapCategoryType
{
    public override string TypeName { get; protected set; } = nameof(SeatingMap);
}
