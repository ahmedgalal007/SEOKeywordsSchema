using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.ActionStatusType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.ActionStatusType.FailedActionStatus;
public class FailedActionStatus : ActionStatusType
{
    public override string TypeName { get; protected set; } = nameof(FailedActionStatus);
}
