using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.WebPageElements;
public class WPHeader : WebPageElement
{
    public override string TypeName { get; protected set; } = nameof(WPHeader);
}
