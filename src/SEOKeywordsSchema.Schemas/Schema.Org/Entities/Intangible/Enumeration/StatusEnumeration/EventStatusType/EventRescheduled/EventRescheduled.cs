using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.EventStatusType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.EventStatusType.EventRescheduled;
public class EventRescheduled : EventStatusType
{
    public override string TypeName { get; protected set; } = nameof(EventRescheduled);
}
