using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ReturnMethodEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.ReturnMethodEnumeration.ReturnInStore;
public class ReturnInStore : ReturnMethodEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ReturnInStore);
}
