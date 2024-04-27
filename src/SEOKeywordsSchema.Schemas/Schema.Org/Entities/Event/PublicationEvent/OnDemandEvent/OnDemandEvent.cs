using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Event.PublicationEvent;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Event.PublicationEvent.OnDemandEvent;
public class OnDemandEvent : PublicationEvent
{
    public override string TypeName { get; protected set; } = nameof(OnDemandEvent);
}
