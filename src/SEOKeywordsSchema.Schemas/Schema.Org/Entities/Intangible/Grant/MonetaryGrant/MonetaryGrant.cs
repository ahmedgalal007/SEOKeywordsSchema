using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Grant;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Grant.MonetaryGrant;
public class MonetaryGrant : Grant
{
    public override string TypeName { get; protected set; } = nameof(MonetaryGrant);
}