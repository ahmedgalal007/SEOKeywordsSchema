using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
public class ActionStatusType : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ActionStatusType);
}


// TODO Member ActiveActionStatus
// TODO Member CompletedActionStatus
// TODO Member FailedActionStatus
// TODO Member PotentialActionStatus