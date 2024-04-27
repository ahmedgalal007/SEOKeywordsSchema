using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Event;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Event.ComedyEvent;
public class ComedyEvent : Event
{
    public override string TypeName { get; protected set; } = nameof(ComedyEvent);
}
