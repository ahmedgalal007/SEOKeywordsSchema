using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.ActionStatusType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.ActionStatusType.PotentialActionStatus;
public class PotentialActionStatus : ActionStatusType
{
    public override string TypeName { get; protected set; } = nameof(PotentialActionStatus);
}
