using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.WebPages;
public class FAQPage : WebPage
{
    public override string TypeName { get; protected set; } = nameof(FAQPage);
}
