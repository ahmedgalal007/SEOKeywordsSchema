using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.ActionStatusType;
public class ActionStatusType : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ActionStatusType);
}


// TODO Member ActiveActionStatus
// TODO Member CompletedActionStatus
// TODO Member FailedActionStatus
// TODO Member PotentialActionStatus