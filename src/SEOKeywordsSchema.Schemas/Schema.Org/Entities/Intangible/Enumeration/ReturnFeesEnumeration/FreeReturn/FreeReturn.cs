using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ReturnFeesEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ReturnFeesEnumeration.FreeReturn;
public class FreeReturn : ReturnFeesEnumeration
{
    public override string TypeName { get; protected set; } = nameof(FreeReturn);
}
