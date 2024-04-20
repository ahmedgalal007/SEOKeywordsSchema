using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Events.PublicationEvents;
public class OnDemandEvent : PublicationEvent
{
    public override string TypeName { get; protected set; } = nameof(OnDemandEvent);
}
