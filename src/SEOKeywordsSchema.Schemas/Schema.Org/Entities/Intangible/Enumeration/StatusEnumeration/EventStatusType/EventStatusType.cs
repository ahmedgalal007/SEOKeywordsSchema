using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.EventStatusType;
public class EventStatusType : StatusEnumeration
{
    public override string TypeName { get; protected set; } = nameof(EventStatusType);
}


// TODO Member EventCancelled
// TODO Member EventMovedOnline
// TODO Member EventPostponed
// TODO Member EventRescheduled
// TODO Member EventScheduled