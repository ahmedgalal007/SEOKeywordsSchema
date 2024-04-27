using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.LegalForceStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.LegalForceStatus.NotInForce;
public class NotInForce : LegalForceStatus
{
    public override string TypeName { get; protected set; } = nameof(NotInForce);
}
