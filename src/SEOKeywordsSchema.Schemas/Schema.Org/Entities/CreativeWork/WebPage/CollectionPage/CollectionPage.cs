using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebPage;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.WebPage.CollectionPage;
public class CollectionPage : WebPage
{
    public override string TypeName { get; protected set; } = nameof(CollectionPage);
}
