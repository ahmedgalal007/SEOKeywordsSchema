using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.EventStatusType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.StatusEnumeration.EventStatusType.EventPostponed;
public class EventPostponed : EventStatusType
{
    public override string TypeName { get; protected set; } = nameof(EventPostponed);
}
