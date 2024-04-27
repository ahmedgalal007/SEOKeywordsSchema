using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.LegalForceStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.LegalForceStatus.PartiallyInForce;
public class PartiallyInForce : LegalForceStatus
{
    public override string TypeName { get; protected set; } = nameof(PartiallyInForce);
}
