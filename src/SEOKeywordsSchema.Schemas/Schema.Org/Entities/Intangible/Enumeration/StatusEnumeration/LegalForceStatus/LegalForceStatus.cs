using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.LegalForceStatus;
public class LegalForceStatus : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(LegalForceStatus);
}


// TODO Member InForce
// TODO Member NotInForce
// TODO Member PartiallyInForce