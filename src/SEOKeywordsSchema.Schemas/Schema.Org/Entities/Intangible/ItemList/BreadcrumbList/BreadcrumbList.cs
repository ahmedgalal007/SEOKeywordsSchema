using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.ItemList;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.ItemList.BreadcrumbList;
public class BreadcrumbList : ItemList
{
    public override string TypeName { get; protected set; } = nameof(BreadcrumbList);
}
