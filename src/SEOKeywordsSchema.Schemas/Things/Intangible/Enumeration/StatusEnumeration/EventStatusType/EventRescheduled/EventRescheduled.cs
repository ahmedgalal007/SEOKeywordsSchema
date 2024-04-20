using SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.StatusEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.StatusEnumerations.EventStatusTypes;
public class EventRescheduled : EventStatusType
{
    public override string TypeName { get; protected set; } = nameof(EventRescheduled);
}
